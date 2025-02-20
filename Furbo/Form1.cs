using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        private Dictionary<String, decimal> jugados;
        private Dictionary<String, decimal> promedio;
        private Dictionary<String, decimal> wr;
        private Dictionary<String, int> pichichis;
        private Dictionary<String, int> total;
        private Dictionary<String, int> pusk;
        private static readonly string API_URL = "https://api.github.com/gists/";
        private static readonly string TRUCO = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_";
        private static readonly string TOKEN = "32,33,41,62,19,55,35,21,13,11,13,2,59,56,6,1,1,46,53,5,48,56,4,61,43,12,13,59,33,31,53,34,12,18,52,59,41,23,6,42";
        private static readonly string GIST_ID = "7bb82bd423d76f52b9d9810341db08a6";
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

            jugados = new Dictionary<string, decimal>();
            promedio = new Dictionary<string, decimal>();
            wr = new Dictionary<string, decimal>();
            pichichis = new Dictionary<string, int>();
            total = new Dictionary<string, int>();
            pusk = new Dictionary<string, int>();
        }

        private async void Furbo_Load(object sender, EventArgs e)
        {

            String jsonContent = await downloadJsonContentGist();

            String jsonContentImg = await downloadJsonContent("https://pastebin.com/raw/U86EbJHE");

            var parsedImg = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContentImg);

            if (!string.IsNullOrEmpty(jsonContent))
            {
                var parsedData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(jsonContent);
                lblInfo.Text = "RECOGIENDO INFORMACIÓN DE JORANDAS...";
                prbBarra.Maximum = parsedData.Count + parsedImg.Count;
                foreach (KeyValuePair<string, Dictionary<string, string>> entry in parsedData)
                {
                    Jornada jornada = new Jornada(entry.Value, entry.Key, stats);
                    dgvJornadas.Rows.Add(entry.Key, jornada.fecha, jornada.equipoGanador.Count + jornada.equipoPerdedor.Count);
                    jornadas.Add(jornada);
                    prbBarra.PerformStep();
                }
            }

            adjustDgv();

            int i = 0;
            foreach (KeyValuePair<string, Stats> entry in stats)
            {
                lblInfo.Text = "RECOGIENDO INFORMACIÓN DE JUGADORES...";
                if (entry.Value.jugados > 0)
                {
                    entry.Value.promedio = entry.Value.totales / entry.Value.jugados;
                    entry.Value.wr = entry.Value.victorias / entry.Value.jugados * 100;
                    jugados.Add(entry.Key, entry.Value.jugados);
                    promedio.Add(entry.Key, entry.Value.promedio);
                    wr.Add(entry.Key, entry.Value.wr);
                    pichichis.Add(entry.Key, entry.Value.pichichis);
                    total.Add(entry.Key, entry.Value.totales);
                    pusk.Add(entry.Key, entry.Value.puskas);
                    imgLista.Images.Add(await Task.Run(() => cargarImagen(parsedImg[entry.Key])));
                    ListViewItem lista = new ListViewItem(entry.Key, i);
                    lwJugadores.Items.Add(lista);
                    i++;
                    prbBarra.PerformStep();
                }
                dgvStats.Rows.Add(entry.Key, entry.Value.jugados, entry.Value.promedio.ToString("F2"), entry.Value.pichichis, entry.Value.wr.ToString("F2") + "%", entry.Value.totales, entry.Value.puskas);
            }
            dgvJornadas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lblInfo.Text = "";
            prbBarra.Hide();
            tcPrincipal.Enabled = true;
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

        static async Task<String> downloadJsonContentGist()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Configura las cabeceras necesarias
                    client.DefaultRequestHeaders.Add("User-Agent", "CSharpApp");
                    client.DefaultRequestHeaders.Add("Authorization", $"token {getToken()}");

                    // Obtén el Gist actual
                    var response = await client.GetAsync(API_URL + GIST_ID);
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Error al obtener el Gist: {response.StatusCode}");
                        return string.Empty;
                    }

                    // Parsear el contenido del Gist
                    var gist = await response.Content.ReadAsStringAsync();
                    var gistJson = JObject.Parse(gist);

                    // Encuentra el archivo JSON dentro del Gist
                    return gistJson["files"]["Furbo_json"]["content"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                return string.Empty;
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
            List<int> tops = new List<int>();
            tops.Add(getPosDec(jugados, selectedItem));
            tops.Add(getPosDec(promedio, selectedItem));
            tops.Add(getPosInt(pichichis, selectedItem));
            tops.Add(getPosDec(wr, selectedItem));
            tops.Add(getPosInt(total, selectedItem));
            tops.Add(getPosInt(pusk, selectedItem));
            foreach (KeyValuePair<string, Stats> entry in stats)
            {
                if (entry.Key.Equals(selectedItem))
                {
                    FrmJugador jug = new FrmJugador(entry.Key, entry.Value, tops);
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

        private int getPosDec(Dictionary<String, decimal> dict, String nombre)
        {
            decimal maxValue = dict.Max(x => x.Value);
            decimal minValue = dict.Min(x => x.Value);
            if (maxValue == dict[nombre])
            {
                return 0;
            }
            else if (minValue == dict[nombre])
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private int getPosInt(Dictionary<String, int> dict, String nombre)
        {
            int maxValue = dict.Max(x => x.Value);
            int minValue = dict.Min(x => x.Value);
            if (maxValue == dict[nombre])
            {
                return 0;
            }
            else if (minValue == dict[nombre])
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private Image cargarImagen(string ruta)
        {
            using (var client = new WebClient())
            {
                byte[] imageBytes = client.DownloadData(ruta);
                using (var stream = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(stream);
                }
            }
        }

        private void lwJugadores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lv = sender as ListView;
            String selectedItem = lv.SelectedItems[0].Text;
            List<int> tops = new List<int>();
            tops.Add(getPosDec(jugados, selectedItem));
            tops.Add(getPosDec(promedio, selectedItem));
            tops.Add(getPosInt(pichichis, selectedItem));
            tops.Add(getPosDec(wr, selectedItem));
            tops.Add(getPosInt(total, selectedItem));
            tops.Add(getPosInt(pusk, selectedItem));
            foreach (KeyValuePair<string, Stats> entry in stats)
            {
                if (entry.Key.Equals(selectedItem))
                {
                    FrmJugador jug = new FrmJugador(entry.Key, entry.Value, tops);
                    jug.ShowDialog();
                }
            }
        }

        private static String getToken()
        {
            String[] partes = TOKEN.Split(',');
            StringBuilder sb = new StringBuilder();
            foreach (String num in partes)
            {
                sb.Append(TRUCO[Int32.Parse(num)]);
            }
            return sb.ToString();
        }
    }
}

