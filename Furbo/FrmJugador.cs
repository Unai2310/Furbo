using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furbo
{
    public partial class FrmJugador : Form
    {
        Stats stats;
        String nombre;
        List<int> tops;
        public FrmJugador(String nombre, Stats stats, List<int> tops)
        {
            InitializeComponent();
            this.stats = stats;
            this.Text = nombre;
            this.nombre = nombre;
            this.tops = tops;
        }

        private async void FrmJugador_Load(object sender, EventArgs e)
        {
            String url = "https://pastebin.com/raw/U86EbJHE";

            String jsonContent = await downloadJsonContent(url);

            var parsedData = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);

            rellenarIndicador(tops[0], pcbJugados);
            rellenarIndicador(tops[1], pcbGoles);
            rellenarIndicador(tops[2], pcbPichichi);
            rellenarIndicador(tops[3], pcbWr);
            rellenarIndicador(tops[4], pcbTotales);
            rellenarIndicador(tops[5], pcbPuskas);
            
            lblNombreData.Text = this.nombre;
            lblPichichiData.Text = this.stats.pichichis.ToString();
            lblPromedioData.Text = this.stats.promedio.ToString("F2");
            lblPuskasData.Text = this.stats.puskas.ToString();
            lblTotalesData.Text = this.stats.totales.ToString();
            lblWrData.Text = this.stats.wr.ToString("F2") + "%";
            LblJugadosData.Text = this.stats.jugados.ToString();
            foreach (KeyValuePair<String, String> entry in parsedData)
            {
                if (entry.Key.Equals(this.nombre))
                {
                    pcbFoto.Image = await Task.Run(() => cargarImagen(entry.Value));
                }
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

        private void rellenarIndicador(int pos, PictureBox pcb)
        {
            if (pos == 0)
            {
                pcb.Image = Properties.Resources.Nuevo;
            } else if (pos == 1)
            {
                pcb.Image = Properties.Resources.Borrar;
            } else
            {
                pcb.Image = null;
            }
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
    }
}
