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
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<string> list = new List<string> {"MENSUALIDAD","MULTA","TRANSFERENCIA"};
        private void FormReporte_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(list.ToArray());
            // Establecer la fecha y hora actual
            DateTime fechaActual = DateTime.Now;

            // Establecer la propiedad MaxDate del DateTimePicker
            dateTimePicker1.MaxDate = fechaActual;
            dateTimePicker1.Value = fechaActual;
            dateTimePicker2.Value = fechaActual;
            dateTimePicker2.MaxDate = fechaActual;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            
            if(comboBox1.SelectedItem != null)
            {
                if(comboBox1.SelectedItem.ToString() == "MENSUALIDAD")
                {
                    reporte.arrayDatos[0] = "1";
                    reporte.arrayDatos[1] = Convert.ToString(dateTimePicker1.Value.Date);
                    reporte.arrayDatos[2] = Convert.ToString(dateTimePicker2.Value.Date);
                    filtroData(reporte.pago());
                }
                else if (comboBox1.SelectedItem.ToString() == "TRANSFERENCIA")
                {
                    reporte.arrayDatos[0] = "2";
                    reporte.arrayDatos[1] = Convert.ToString(dateTimePicker1.Value.Date);
                    reporte.arrayDatos[2] = Convert.ToString(dateTimePicker2.Value.Date);
                    filtroData(reporte.pago());
                    
                }
                else if(comboBox1.SelectedItem.ToString() == "MULTA")
                {
                    reporte.arrayDatos[0] = Convert.ToString(dateTimePicker1.Value.Date);
                    reporte.arrayDatos[1] = Convert.ToString(dateTimePicker2.Value.Date);
                    filtroData(reporte.pagoMixto());
                }
                else
                {
                    MessageBox.Show("Seleccione una opcion");
                }
                
                
            }

        }

        
        private void filtroData(DataTable tabla)
        {
            if(tabla.Rows.Count > 0)
            {
                // Obtenemos la suma de la columna "miColumna"
                double suma1 = Convert.ToDouble(tabla.Compute("SUM(monto)", ""));


                // Crear una nueva fila
                DataRow nuevaFila = tabla.NewRow();

                // Establecer los valores de las columnas de la nueva fila
                nuevaFila["monto"] = suma1.ToString();
                nuevaFila["nombre"] = "Total";
                // ...

                // Agregar la nueva fila al DataTable
                tabla.Rows.Add(nuevaFila);

                dataGridView1.DataSource = tabla;
                estiloTabla();
            }
            else
            {
                var tem = new DataGridView();
                ShowCustomMessageBox("No se encontraron DEUDAS en esas fechas", "Alerta", "Aceptar");
                dataGridView1.DataSource = tem;
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

        public void ShowCustomMessageBox(string message, string title, string buttonText)
        {
            Form messageBox = new Form();
            Label label = new Label();
            Button button = new Button();

            messageBox.StartPosition = FormStartPosition.CenterScreen;
            messageBox.FormBorderStyle = FormBorderStyle.None;
            messageBox.BackColor = Color.White;
            messageBox.ClientSize = new Size(300, 100);

            label.Text = message;
            label.AutoSize = true;
            label.Location = new Point(20, 20);
            label.Font = new Font("Segoe UI", 10);

            button.Text = buttonText;
            button.BackColor = Color.FromArgb(0, 192, 192);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Size = new Size(80, 30);
            button.Location = new Point(110, 60);
            button.Font = new Font("Segoe UI", 10);
            button.Click += (sender, e) => { messageBox.Dispose(); };

            messageBox.Controls.Add(label);
            messageBox.Controls.Add(button);
            messageBox.ShowDialog();
        }
        private void ShowAlertMessage(string message)
        {
            Form alertForm = new Form();
            alertForm.BackColor = Color.WhiteSmoke;
            alertForm.FormBorderStyle = FormBorderStyle.None;
            alertForm.StartPosition = FormStartPosition.CenterScreen;
            alertForm.Size = new Size(300, 150);

            Label alertLabel = new Label();
            alertLabel.ForeColor = Color.Red;
            alertLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            alertLabel.Location = new Point(75, 50);
            alertLabel.Text = "¡Alerta!";

            PictureBox alertIcon = new PictureBox();
            alertIcon.Image = Properties.Resources.info;
            alertIcon.SizeMode = PictureBoxSizeMode.Zoom;
            alertIcon.Location = new Point(30, 45);
            alertIcon.Size = new Size(32, 32);

            Label messageLabel = new Label();
            messageLabel.Font = new Font("Arial", 10);
            messageLabel.Location = new Point(75, 80);
            messageLabel.Size = new Size(200, 50);
            messageLabel.Text = message;

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Font = new Font("Arial", 10);
            okButton.BackColor = Color.FromArgb(48, 102, 145);
            okButton.ForeColor = Color.White;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.FlatAppearance.BorderSize = 0;
            okButton.Size = new Size(80, 30);
            okButton.Location = new Point(110, 110);
            okButton.Click += (sender, e) => alertForm.Close();

            alertForm.Controls.Add(alertLabel);
            alertForm.Controls.Add(alertIcon);
            alertForm.Controls.Add(messageLabel);
            alertForm.Controls.Add(okButton);
            alertForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
