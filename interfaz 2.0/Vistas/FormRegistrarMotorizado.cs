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
    public partial class FormRegistrarMotorizado : Form
    {
        public FormRegistrarMotorizado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Capa_Negocio.Linea l = new Capa_Negocio.Linea();
        Capa_Negocio.moto _moto = new Capa_Negocio.moto();
        Capa_Negocio.socio _socio = new Capa_Negocio.socio();
        private void btnSave_Click(object sender, EventArgs e)
        {
            _moto.listaMoto[0] = txtMarca.Text;
            _moto.listaMoto[1] = txtModelo.Text;
            _moto.listaMoto[2] = txtInterno.Text;
            _moto.listaMoto[3] = txtPlaca.Text;
            object L = l.linea();
            if (_socio.existeSocio(txtInterno.Text) == true)
            {
                if (_moto.agregar(L) == 1)
                {
                    MessageBox.Show("Registro de motorizado existos");
                    l.flinea(L);
                }
                else
                {
                    l.DeshacerLinea(L);
                }
            }
            else
            {
                MessageBox.Show("Socio no existe");
            }
            

        }
    }
}
