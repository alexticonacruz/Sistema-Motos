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
        Capa_Negocio.deuda _deuda = new deuda();
        Capa_Negocio.Linea l = new Linea();
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem != null)
            {
               
                object L = l.linea();
                var categoria = _deuda.buscarNameCategory(L,comboBox1.SelectedItem.ToString());


                string interno = textBox1.Text;
                string[] dato = new string[] { interno, categoria};

                socio s = new socio();
                dataGridView1.DataSource = s.historialSocio(dato);
            }
            
        }

        private void historialSocio_Load(object sender, EventArgs e)
        {
            categoriaDeuda cat = new categoriaDeuda();
            comboBox1.Items.AddRange(cat.listCategoria().ToArray());
        }

        private void historialSocio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
