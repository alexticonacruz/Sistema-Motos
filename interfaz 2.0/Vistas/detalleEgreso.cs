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
    public partial class detalleEgreso : Form
    {
        public detalleEgreso()
        {
            InitializeComponent();
        }
        Capa_Negocio.egresos _egreso = new Capa_Negocio.egresos();
        private void detalleEgreso_Load(object sender, EventArgs e)
        {
            if(_egreso.inicio().Rows.Count > 0)
            {
                dataGridView1.DataSource = _egreso.inicio();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string[] dato = new string[2];

            dato[0] = dateTimePicker1.Value.Date.ToString();
            dato[1] = dateTimePicker2.Value.Date.ToString();
            if(_egreso.egreso(dato).Rows.Count > 0)
            {
                dataGridView1.DataSource = _egreso.egreso(dato);
            }
            else
            {
                MessageBox.Show("No hay Egresos en esas fechas");
            }
            
        }
    }
}
