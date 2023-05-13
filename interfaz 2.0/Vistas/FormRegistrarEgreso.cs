using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz_2._0
{
    public partial class FormRegistrarEgreso : Form
    {
        public FormRegistrarEgreso()
        {
            InitializeComponent();
        }
        //Capa_Negocio.egresos _egreso = new Capa_Negocio.egresos();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Capa_Negocio.caja _caja = new Capa_Negocio.caja();
        Capa_Negocio.Linea l = new Capa_Negocio.Linea();
        private void btnSave_Click(object sender, EventArgs e)
        {
            Capa_Negocio.egresos _egreso = new Capa_Negocio.egresos();

            object L = l.linea();

            _egreso.listaEgreso[0] = txtMonto.Text;
            _egreso.listaEgreso[1] = txtDetalle.Text;
            _egreso.listaEgreso[2] = Convert.ToString(dateTimePicker1.Value.Date);

            if(_egreso.agregar(L) == 1)// is true , se subio el egreso
            {
                if(_caja.descontar(Convert.ToInt32(txtMonto.Text),L) == 1)
                {
                    MessageBox.Show("Se registro el egreso, se actualizo el dinero de caja");
                    l.flinea(L);
                }
                else
                {
                    l.DeshacerLinea(L);
                }
            }
            else
            {
                l.DeshacerLinea(L);
            }
        }
        public void cargar()
        {

        }
    }
}
