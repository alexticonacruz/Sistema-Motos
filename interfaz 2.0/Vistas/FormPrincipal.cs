using Capa_Datos.Cache;
using interfaz_2._0.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz_2._0
{
    public partial class FormPrincipal : Form
    {
        private Form currentChildForm;
        public FormPrincipal()
        {
            InitializeComponent();
            CustomizeDesing();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //codigo para abrir formularios
        #region AbrirFormulario
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelcentral.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelcentral.Controls.Add(formulario);
                panelcentral.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        #endregion

        //codigo para sub menu
        #region PanelDeSubMenu
        private void CustomizeDesing()
        {
            panelsubmenu.Visible = false;
            panelsubmenusocio.Visible = false;
            Submenudeudas.Visible = false;
            Submenuegreso.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelsubmenu.Visible = true)
                panelsubmenu.Visible = false;
            if (panelsubmenusocio.Visible = true)
                panelsubmenusocio.Visible = false;
            if (Submenudeudas.Visible = true)
                Submenudeudas.Visible = false;
            if (Submenuegreso.Visible = true)
                Submenuegreso.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

        //panel diseño
        #region Diseño paneles
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            base.WndProc(ref m);
        //            var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
        //            if (sizeGripRectangle.Contains(hitPoint))
        //                m.Result = new IntPtr(HTBOTTOMRIGHT);
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelprincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        #endregion
        private void panelcentro_Paint(object sender, PaintEventArgs e)
        {

        }
        int lx, ly;
        int sw, sh;

        private void panelcabecera_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
      
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panelcabecera_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelcabecera_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            showSubMenu(panelsubmenu);
        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnsub1_Click(object sender, EventArgs e)
        {
           
            HideSubMenu();
        }

        private void btnsub2_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FormFaltas>();
            OpenChildForm(new FormFaltas());
            HideSubMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelsubmenusocio);
            
        }
        // barra superior de diseño 
        #region BarraSuperior
        private void btnmax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnmax.Visible = false;
            button1.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnmax.Visible = true;
            button1.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistrarAsociación>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(Submenuegreso);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubMenu(Submenudeudas);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistrarMotorizado>();
        }

        private void btnagregarsocio_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FormRegistrarSocio());
        }

        private void btnactualizarsocio_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FormActualizarsocio());
        }

        private void panelcentral_Paint(object sender, PaintEventArgs e)
        {
            ManagePermissions();
        }
        private void ManagePermissions()
        {
            if (UserCache.Position == Positions.Presidente)
            {


            }
            if (UserCache.Position == Positions.VicePresidente)
            {
                //Codes
            }
            if (UserCache.Position == Positions.Tesorera)
            {
                //Codes
            }
            if (UserCache.Position == Positions.secretaria)
            {
                btnsub1.Enabled = false;
                btnagregarsocio.Enabled = false;
                btnactualizarsocio.Enabled = false;
                button12.Enabled = false;
                button3.Enabled = false;
                button8.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FormReporte>();
            FormReporte formulario = new FormReporte();
            cambiaformularios(formulario);
        }

        private void btnmin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new listaSocio());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FormRegistrarEgreso());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FormRegistrarDeuda());
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new historialSocio());
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new detalleEgreso());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new AddMensualidad());
        }
        #endregion

        /*Code by alex */
        public void cambiaformularios(Form formulario)
        {
            if (panelcentral.Controls.Count > 0)
            {
                // Supongamos que el formulario está contenido en el índice 0 del panel
                Form form = (Form)panelcentral.Controls[0]; // Obtener el formulario del panel
                form.Close(); // Cerrar el formulario
                panelcentral.Controls.Remove(form); // Eliminar el formulario del panel

            }
            // Establecer la propiedad TopLevel del formulario en false
            formulario.TopLevel = false;

            // Establecer la propiedad Dock del formulario en DockStyle.Fill
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al control Controls del panel
            panelcentral.Controls.Add(formulario);

            // Mostrar el formulario
            formulario.Show();
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelcentral.Controls.Add(childForm);
            panelcentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
