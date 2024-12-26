using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            imagenes = new Dictionary<string, string>()
            { 
                { "Dani", "" },
                { "JuanPa", "https://files.catbox.moe/wt8f3n.jpeg" },
                { "Rurru", "https://files.catbox.moe/rdqgvi.jpeg" },
                { "Juanjo", "https://files.catbox.moe/t29c1s.jpeg" },
                { "Oscar", "https://files.catbox.moe/l7ipe7.jpeg" },
                { "Puvero", "https://files.catbox.moe/u6tzv6.jpeg" },
                { "Raul", "https://files.catbox.moe/vdrlz2.jpeg" },
                { "Javixu", "https://files.catbox.moe/gu0b1m.jpeg" },
                { "Pito", "https://files.catbox.moe/rnl8ql.jpeg" },
                { "Unai", "https://files.catbox.moe/foovf2.jpeg" },
                { "Davisote", "https://files.catbox.moe/sqlars.jpeg" },
                { "Davisito", "https://files.catbox.moe/etbhuo.jpeg" },
                { "Felipe", "https://files.catbox.moe/akw8vk.jpeg" },
                { "Almendra", "https://files.catbox.moe/ysjsn0.jpeg" },
                { "Pol", "https://files.catbox.moe/1dopg4.jpeg" },
                { "Invitados", "https://files.catbox.moe/a7hy8q.jpeg" }
            };
            this.stats = stats;
            this.Text = nombre;
            this.nombre = nombre;
        }

        private void FrmJugador_Load(object sender, EventArgs e)
        {
            lblNombreData.Text = this.nombre;
            lblPichichiData.Text = this.stats.pichichis.ToString();
            lblPromedioData.Text = this.stats.promedio.ToString("F2");
            lblPuskasData.Text = this.stats.puskas.ToString();
            lblTotalesData.Text = this.stats.totales.ToString();
            lblWrData.Text = this.stats.wr.ToString("F2") + "%";
            LblJugadosData.Text = this.stats.jugados.ToString();
            foreach (KeyValuePair<String, String> entry in imagenes)
            {
                if (entry.Key.Equals(this.nombre))
                {
                    pcbFoto.Load(entry.Value);
                }
            }
        }
    }
}
