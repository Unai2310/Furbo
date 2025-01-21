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
    public partial class FrmJugador : Form
    {
        Stats stats;
        String nombre;
        Dictionary<string, string> imagenes;
        public FrmJugador(String nombre, Stats stats)
        {
            InitializeComponent();
            this.stats = stats;
            this.Text = nombre;
            this.nombre = nombre;
        }

        private async void FrmJugador_Load(object sender, EventArgs e)
        {
            String url = "https://pastebin.com/raw/U86EbJHE";

            String jsonContent = await downloadJsonContent(url);

            var parsedData = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);

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
                    pcbFoto.Load(entry.Value);
                }
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
