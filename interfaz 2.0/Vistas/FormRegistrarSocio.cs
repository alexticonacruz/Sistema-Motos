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
    public partial class FormRegistrarSocio : Form
    {
        public FormRegistrarSocio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Linea L = new Linea();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            object l = L.linea();

            persona p1 = new persona();
            socio s1 = new socio();

            string nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;

            //Nombres
            // Separamos el nombre completo en partes separadas
            char[] separadores = { ' ' };
            string[] partesNombres = nombres.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            //Apellidos
            // Separamos el nombre completo en partes separadas
            char[] separadores1 = { ' ' };
            string[] partesApellidos = apellidos.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            if (partesNombres.Length == 1) /* para 1 nombre */
            {

                p1.nombre = partesNombres[0];
                if (partesApellidos.Length == 1)
                {
                    p1.apellidoPaterno = partesApellidos[0];
                }
                else if (partesApellidos.Length == 2)
                {
                    p1.apellidoPaterno = partesApellidos[0];
                    p1.apellidoMaterno = partesApellidos[1];
                }
                p1.cedulaIdentidad = int.Parse(txtCI.Text);
                p1.domicilio = txtDomicilio.Text;
                p1.celular = int.Parse(txtCelular.Text);
            }
            else if(partesNombres.Length == 2) /* para 2 nombre */
            {
                p1.nombre = partesNombres[0];
                p1.nombretwo = partesNombres[1];

                if (partesApellidos.Length == 1)
                {
                    p1.apellidoPaterno = partesApellidos[0];
                }
                else if(partesApellidos.Length == 2) 
                {
                    p1.apellidoPaterno = partesApellidos[0];
                    p1.apellidoMaterno = partesApellidos[1];
                }
                p1.cedulaIdentidad = int.Parse(txtCI.Text);
                p1.domicilio = txtDomicilio.Text;
                p1.celular = int.Parse(txtCelular.Text);

            }
            if (p1.agregarPersona(p1, l) == 1)
            {
                string maxPersona = p1.ultimaPersona(l);

                s1.personaId = int.Parse(maxPersona);
                s1.estado = "A";

                if (s1.agregar(s1, l) == 1)
                {
                    MessageBox.Show("Guardado Con Exito");
                    L.flinea(l);
                }
                else
                {
                    MessageBox.Show("No se guardo");
                    L.DeshacerLinea(l);
                }

            }
        }
    }
}
