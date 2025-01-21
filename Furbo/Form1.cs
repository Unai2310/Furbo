using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furbo
{
    public partial class Furbo : Form
    {
        private List<Jornada> jornadas;
        private Dictionary<String, Stats> stats;
        public Furbo()
        {
            InitializeComponent();
            jornadas = new List<Jornada>();
            stats = new Dictionary<String, Stats>();
            stats.Add("Pito", new Stats());
            stats.Add("Rurru", new Stats());
            stats.Add("Juanjo", new Stats());
            stats.Add("Puvero", new Stats());
            stats.Add("Davisote", new Stats());
            stats.Add("Raul", new Stats());
            stats.Add("Unai", new Stats());
            stats.Add("Oscar", new Stats());
            stats.Add("Davisito", new Stats());
            stats.Add("JuanPa", new Stats());
            stats.Add("Dani", new Stats());
            stats.Add("Almendra", new Stats());
            stats.Add("Javixu", new Stats());
            stats.Add("Felipe", new Stats());
            stats.Add("Pol", new Stats());
            stats.Add("Invitados", new Stats());
        }

        private async void Furbo_Load(object sender, EventArgs e)
        {
            String url = "https://pastebin.com/raw/R6vs6nXU";

            String jsonContent = await downloadJsonContent(url);

            dgvJornadas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (!string.IsNullOrEmpty(jsonContent))
            {
                var parsedData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(jsonContent);

                prbBarra.Maximum = parsedData.Count;
                foreach (KeyValuePair<string, Dictionary<string, string>> entry in parsedData)
                {
                    Jornada jornada = new Jornada(entry.Value, entry.Key, stats);
                    dgvJornadas.Rows.Add(entry.Key, jornada.fecha, jornada.equipoGanador.Count + jornada.equipoPerdedor.Count);
                    jornadas.Add(jornada);
                    prbBarra.PerformStep();
                }
            }

            adjustDgv();

            foreach (KeyValuePair<string, Stats> entry in stats)
            {
                if (entry.Value.jugados > 0)
                {
                    entry.Value.promedio = Decimal.Round(entry.Value.totales / entry.Value.jugados, 2);
                    entry.Value.wr = Decimal.Round(entry.Value.victorias / entry.Value.jugados, 2) * 100;
                }
                dgvStats.Rows.Add(entry.Key, entry.Value.jugados, entry.Value.promedio.ToString("F2"), entry.Value.pichichis, entry.Value.wr.ToString("F2") + "%", entry.Value.totales, entry.Value.puskas);
            }
            prbBarra.Hide();
        }

        private void adjustDgv()
        {
            dgvStats.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        static async Task<String> downloadJsonContent(String url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {

                        return await response.Content.ReadAsStringAsync();

                    }
                    else
                    {
                        Console.WriteLine("Error");
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                    return string.Empty;
                }
            }
        }

        private void DtgJorndadas_CellClick(object sender, DataGridViewCellEventArgs e) //CLICK JORNADA
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvJornadas.Rows[e.RowIndex];
                foreach (Jornada jor in jornadas)
                {
                    if (jor.nombre.Equals(row.Cells[0].Value.ToString()))
                    {
                        lblJornada.Text = jor.nombre;
                        txtGanador.Text = jor.resultadoGanador.ToString();
                        rellenarList(jor.equipoGanador, lvGanador);
                        txtPerdedor.Text = jor.resultadoPerdedor.ToString();
                        rellenarList(jor.equipoPerdedor, lvPerdedor);
                        lblMaxData.Text = jor.max;
                        lblPichichiData.Text = jor.pichichi;
                        lblPuskasData.Text = jor.puskas;
                        lbltotalData.Text = jor.total;
                    }
                }
            }
        }

        private void rellenarList(List<Jugador> jugadores, ListView lv)
        {
            lv.Items.Clear();
            foreach (Jugador j in jugadores)
            {
                ListViewItem item = new ListViewItem(j.nombre);
                item.SubItems.Add(j.goles);
                lv.Items.Add(item);
            }
        }

        private void jugadorSeleccionado(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            String selectedItem = lv.SelectedItems[0].Text;
            foreach (KeyValuePair<string, Stats> entry in stats)
            {
                if (entry.Key.Equals(selectedItem))
                {
                    FrmJugador jug = new FrmJugador(entry.Key, entry.Value);
                    jug.ShowDialog();
                }
            }
        }
        private void dgvStats_CellClick(object sender, DataGridViewCellEventArgs e) //CLICK JUGADOR
        {
            dgvResul.Rows.Clear();
            dgvResul.Columns.Clear();
            
            String resultado = "";
            String goles = "";
            int victorias = 0;
            int derrotas = 0;
            int bajas = 0;
            DataGridViewRow rowVict = new DataGridViewRow();
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvStats.Rows[e.RowIndex];
                foreach (Jornada jor in jornadas)
                {
                    resultado = getResul(row.Cells[0].Value.ToString(), jor, ref victorias, ref derrotas, ref bajas);
                    goles = getGoles(row.Cells[0].Value.ToString(), jor);
                    rellenarVict(jor.nombre, goles, resultado, rowVict);
                }
                lblResul.Text = "Resultados de " + row.Cells[0].Value.ToString() + 
                    "    Victorias: " + victorias.ToString() + 
                    "    Derrotas: " + derrotas.ToString() +
                    "    Bajas: " + bajas.ToString();
            }
            if (!resultado.Equals("") && !goles.Equals(""))
            {
                dgvResul.Rows.Add(rowVict);
            }
        }

        private void rellenarVict(string nombre, String goles, string resultado, DataGridViewRow row)
        {
            int nuevaColumnaIndex = dgvResul.ColumnCount;
            dgvResul.Columns.Add($"Columna{nuevaColumnaIndex + 1}", nombre);

            DataGridViewTextBoxCell celda = new DataGridViewTextBoxCell();
            celda.Value = goles.Replace("X", " ");
            Color color;
            switch (resultado)
            {
                case "0":
                    color = Color.LightGreen;  // Gano el primer equipo
                    break;
                case "1":
                    color = Color.Red;  // Gano el segundo equipo
                    break;
                default:
                    color = Color.Gray;  // Resultado no definido (empate u otro)
                    break;
            }
            celda.Style.BackColor = color;
            celda.Style.SelectionBackColor = color;
            celda.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            row.Cells.Add(celda);
        }


        private String getResul(String nombre, Jornada jornada, ref int vic, ref int der, ref int baj)
        {
            foreach (Jugador jug in jornada.todos)
            {
                if (nombre.Equals(jug.nombre))
                {
                    switch (jug.resultado)
                    {
                        case "0":
                            vic++;
                            break;
                        case "1":
                            der++;
                            break;
                        default:
                            baj++;
                            break;
                    }
                    return jug.resultado;
                }
            }
            return "X-X";
        }

        private String getGoles(String nombre, Jornada jornada)
        {
            foreach (Jugador jug in jornada.todos)
            {
                if (nombre.Equals(jug.nombre))
                {
                    return jug.goles;
                }
            }
            return "X-X";
        }
    }
}

