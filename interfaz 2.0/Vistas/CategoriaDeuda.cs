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
    public partial class CategoriaDeuda : Form
    {
        public CategoriaDeuda()
        {
            InitializeComponent();
        }
        Capa_Negocio.Linea l = new Capa_Negocio.Linea();
        private void btnSave_Click(object sender, EventArgs e)
        {
            Capa_Negocio.categoriaDeuda _catDeuda= new Capa_Negocio.categoriaDeuda();

            object L = l.linea();

            _catDeuda.nombre = txtNombre.Text;

            if(_catDeuda.crear(_catDeuda, L) == 1)
            {
                MessageBox.Show("Registrado con exito la categoria");
                l.flinea(L);
            }
            else
            {
                MessageBox.Show("Fallo al registrar");
                l.DeshacerLinea(L);
            }
        }

        private void CategoriaDeuda_Load(object sender, EventArgs e)
        {

        }
    }
}
