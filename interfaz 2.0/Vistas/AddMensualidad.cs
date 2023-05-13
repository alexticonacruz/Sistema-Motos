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
    public partial class AddMensualidad : Form
    {
        public AddMensualidad()
        {
            InitializeComponent();
        }
        Capa_Negocio.detalleDeuda _deuda = new Capa_Negocio.detalleDeuda();
        Capa_Negocio.socio _socio = new Capa_Negocio.socio();
        Capa_Negocio.Linea l = new Capa_Negocio.Linea();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;

            object L = l.linea();

            int cantidad = Convert.ToInt32(_deuda.totalSocio(L));
            _deuda.mensualidad[0] = fechaActual.ToString();
            _deuda.mensualidad[1] = txtMensualidad.Text;
            _deuda.mensualidad[2] = cantidad.ToString();
            if(_deuda.cargaMasimaMensulidad(L) == 1)
            {
                l.flinea(L);
                MessageBox.Show("Se registro la nueva deuda");
            }
            else
            {
                l.DeshacerLinea(L); 
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
