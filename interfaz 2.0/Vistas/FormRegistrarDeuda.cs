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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace interfaz_2._0
{
    public partial class FormRegistrarDeuda : Form
    {
        public FormRegistrarDeuda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Capa_Negocio.detalleDeuda _deuda = new Capa_Negocio.detalleDeuda();
        Capa_Negocio.deuda _tipoDeuda = new Capa_Negocio.deuda();
        Linea L = new Linea();
        private void button2_Click(object sender, EventArgs e)
        {
            object l = L.linea();

            DateTime fechaActual = DateTime.Now;

            _deuda.socioId = int.Parse(txtSocioId.Text);
            _deuda.descripcion = txtDescripcion.Text;
            _deuda.fecha = fechaActual.ToString("dd/MM/yyyy");
            _deuda.estado = "A";
            if (cbbDeudas.SelectedItem != null)
            {
                var selectItem = cbbDeudas.SelectedItem;
                int id = _tipoDeuda.byId(selectItem.ToString());
                _deuda.deudaId = id;
                if (_deuda.crearDeuda(_deuda, l) == 1)
                {
                    MessageBox.Show("Guardado con exito");
                    L.flinea(l);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la deuda");
                    L.DeshacerLinea(l);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de multa");
            }
            // falta el tipo de deuda
            // el tipo de deuda aparecera en el combobox

            //_deuda.crearDeuda(_deuda);

        }

        private void FormRegistrarDeuda_Load(object sender, EventArgs e)
        {
            List<string> listTipos = _deuda.cargartiposDeudas();
            cbbDeudas.Items.AddRange(listTipos.ToArray());
        }
    }
}
