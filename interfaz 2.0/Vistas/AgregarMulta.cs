using Capa_Negocio;
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
    public partial class AgregarMulta : Form
    {
        public AgregarMulta()
        {
            InitializeComponent();
        }
        
        Capa_Negocio.Linea l = new Linea();
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (cbbCategoria.SelectedItem != null)
            {
                object L = l.linea();

                Capa_Negocio.deuda _deuda = new Capa_Negocio.deuda();
                _deuda.nombre = txtNombre.Text;
                _deuda.monto = Convert.ToInt32(txtMonto.Text);
                //_deuda.categoriaId = cbbCategoria.SelectedItem;
                _deuda.categoriaId = Convert.ToInt32(_deuda.buscarNameCategory(L,cbbCategoria.SelectedItem.ToString()));
                if(_deuda.crearDeuda(_deuda, L) == 1)
                {
                    MessageBox.Show("Guardado Con exito");
                    l.flinea(L); 
                }
                else
                {
                    l.DeshacerLinea(L);
                    MessageBox.Show("Fallo al guardar");
                }
            }
            /* Combobox */
        }

        private void AgregarDeuda_Load(object sender, EventArgs e)
        {
            categoriaDeuda cat = new categoriaDeuda();
            cbbCategoria.Items.AddRange(cat.listCategoria().ToArray());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
