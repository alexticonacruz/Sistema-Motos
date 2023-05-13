using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace interfaz_2._0.Vistas
{
    public partial class historialSocio : Form
    {
        public historialSocio()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            socio s = new socio();
            dataGridView1.DataSource = s.historialSocio();
        }

        private void historialSocio_Load(object sender, EventArgs e)
        {

        }

        private void historialSocio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
