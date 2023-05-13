using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz_2._0.Vistas
{
    public partial class listaSocio : Form
    {
        public listaSocio()
        {
            InitializeComponent();
        }
        Capa_Negocio.socio _socio = new Capa_Negocio.socio();
        private void listaSocio_Load(object sender, EventArgs e)
        {
            if(_socio.listaSocios().Rows.Count > 0)
            {
                dataGridView1.DataSource = _socio.listaSocios();
                estiloTabla();
            }
            else
            {
                MessageBox.Show("Vaya no hay socios");
            }
        }
        public void estiloTabla()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Personalizar la apariencia del DataGridView
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 236, 239);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Establecer el estilo para las celdas de los datos
            //dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Establecer el color de fondo de las filas alternas
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo para las celdas seleccionadas
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
