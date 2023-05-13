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
    public partial class FormFaltas : Form
    {
        public FormFaltas()
        {
            InitializeComponent();
        }
        Capa_Negocio.deuda _deuda = new Capa_Negocio.deuda();
        Capa_Negocio.socio _socio = new Capa_Negocio.socio();
        Capa_Negocio.ingreso _ingreso = new Capa_Negocio.ingreso();
        Capa_Negocio.Linea L = new Capa_Negocio.Linea();
        Capa_Negocio.caja _caja = new Capa_Negocio.caja();

        private string[] datosFilaSeleccionada;
        List<string[]> cartDeuda = new List<string[]>();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFaltas_Load(object sender, EventArgs e)
        {
            if(_deuda.consultarDeuda() != null)
            {
                if(_deuda.consultarDeuda().Rows.Count > 0)
                {
                    dataGridView1.DataSource = _deuda.consultarDeuda();
                    estiloTabla();
                    estiloTabla2();
                    /* --- para que no se vea la primer columna */
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Visible = false;
                    DataGridViewColumn column2 = dataGridView2.Columns[0];
                    column2.Visible = false;

                }
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
        public void estiloTabla2()
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Personalizar la apariencia del DataGridView
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 236, 239);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;

            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Establecer el estilo para las celdas de los datos
            //dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Establecer el color de fondo de las filas alternas
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo para las celdas seleccionadas
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _deuda.consultarDeuda(textBox1.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (datosFilaSeleccionada != null) // guarda en la lista
            {
                int c = 0;
                foreach (string[] item in cartDeuda) // verifica a cada bucle su id
                {
                    if (item[0] == datosFilaSeleccionada[0])
                    {
                        c++;
                    }
                }
                if (c != 1)
                {
                    cartDeuda.Add(datosFilaSeleccionada);
                }
                else
                {
                    MessageBox.Show("Ya ingresaste esa deuda");
                }

            }
            dataGridView2.Rows.Clear();

            foreach (string[] item in cartDeuda) //carga al grid2
            {

                dataGridView2.Rows.Add(item);
            }


            DataGridViewColumn column = dataGridView2.Columns[0];
            column.Visible = false; 
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count == 1 )
            {
                MessageBox.Show("Valla no haz seleccionado ninguna deuda");
            }
            else
            {
                object l = L.linea();

                DateTime fechaActual = DateTime.Now;

                List<string> idsDeuda = montoTotal(cartDeuda);
                decimal monto = Convert.ToDecimal(idsDeuda[idsDeuda.Count - 1]); //monto total de todas las deudas
                idsDeuda.RemoveAt(idsDeuda.Count - 1); // elimina el monto que tenia y deja solo los ids de las deudas

                _ingreso.monto = Convert.ToInt32(monto);
                _ingreso.descripcion = "pagado";
                _ingreso.usuarioId = 1;
                _ingreso.cajaId = 1;
                _ingreso.fecha = fechaActual.ToString("dd/MM/yyyy");

                if (_ingreso.agregar(_ingreso, l) == 1)// verifica si se registro el ingreso
                {
                    string llaveID = _ingreso.ultimaIngreso(l);
                    foreach (var item in idsDeuda)
                    {
                        Capa_Negocio.detalleIngreso _detalleIngreso = new Capa_Negocio.detalleIngreso();
                        _detalleIngreso.ingresoId = int.Parse(llaveID);
                        _detalleIngreso.deudaId = Convert.ToInt32(item);
                        if (_detalleIngreso.agregar(_detalleIngreso, l) == 1)
                        {
                            if (_deuda.actualizar(Convert.ToInt32(item), l) == 1)
                            {
                                MessageBox.Show("entro a actualizar la deuda del socio");
                            }
                            MessageBox.Show("Pago Existoso");
                        }
                        else
                        {
                            MessageBox.Show("Fallo al completar el pago");
                        }
                    }
                    // actualizar el monto de la base  de datos triger manual 
                    if (_caja.agregar(Convert.ToInt32(monto), l) == 1)
                    {
                        MessageBox.Show("se Actualizo la CAJA");

                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la CAJA");
                    }
                    L.flinea(l);
                }
                else
                {
                    L.DeshacerLinea(l);
                }
            }
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (_socio.existeSocio(textBox1.Text))
                {
                    dataGridView1.DataSource = _deuda.consultarDeuda(textBox1.Text);
                }
            }
            else
            {
                dataGridView1.DataSource = _deuda.consultarDeuda();
            }
        }
        private List<string> montoTotal(List<string[]> list)
        {
            List<string> idDeudas = new List<string>();
            decimal montoTotal = 0;

            foreach (string[] item in list)
            {
                idDeudas.Add(item[0]); // almacena deudaId
                montoTotal += Convert.ToDecimal(item[6]);
            }
            idDeudas.Add(montoTotal.ToString());
            return idDeudas;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                datosFilaSeleccionada = new string[filaSeleccionada.Cells.Count];
                for (int i = 0; i < filaSeleccionada.Cells.Count; i++)
                {
                    datosFilaSeleccionada[i] = filaSeleccionada.Cells[i].Value.ToString();
                }

                // seleccionar toda la fila
                dataGridView1.ClearSelection();
                filaSeleccionada.Selected = true;
            }
        }
    }
}
