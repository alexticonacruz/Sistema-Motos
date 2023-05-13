namespace interfaz_2._0
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.panelcentral = new System.Windows.Forms.Panel();
            this.panellateral = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Submenudeudas = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Submenuegreso = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelsubmenusocio = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnactualizarsocio = new System.Windows.Forms.Button();
            this.btnagregarsocio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelsubmenu = new System.Windows.Forms.Panel();
            this.btnsub2 = new System.Windows.Forms.Button();
            this.btnsub1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.panelcabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.panelprincipal.SuspendLayout();
            this.panellateral.SuspendLayout();
            this.Submenudeudas.SuspendLayout();
            this.Submenuegreso.SuspendLayout();
            this.panelsubmenusocio.SuspendLayout();
            this.panelsubmenu.SuspendLayout();
            this.panelcabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelprincipal
            // 
            this.panelprincipal.Controls.Add(this.panelcentral);
            this.panelprincipal.Controls.Add(this.panellateral);
            this.panelprincipal.Controls.Add(this.panelcabecera);
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprincipal.Location = new System.Drawing.Point(0, 0);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(1200, 700);
            this.panelprincipal.TabIndex = 2;
            this.panelprincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcentro_Paint);
            // 
            // panelcentral
            // 
            this.panelcentral.BackColor = System.Drawing.Color.White;
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.Location = new System.Drawing.Point(200, 32);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(1000, 668);
            this.panelcentral.TabIndex = 5;
            this.panelcentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcentral_Paint);
            // 
            // panellateral
            // 
            this.panellateral.AutoScroll = true;
            this.panellateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.panellateral.Controls.Add(this.button6);
            this.panellateral.Controls.Add(this.button5);
            this.panellateral.Controls.Add(this.Submenudeudas);
            this.panellateral.Controls.Add(this.button4);
            this.panellateral.Controls.Add(this.Submenuegreso);
            this.panellateral.Controls.Add(this.button3);
            this.panellateral.Controls.Add(this.panelsubmenusocio);
            this.panellateral.Controls.Add(this.button2);
            this.panellateral.Controls.Add(this.panelsubmenu);
            this.panellateral.Controls.Add(this.btn3);
            this.panellateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellateral.Location = new System.Drawing.Point(0, 32);
            this.panellateral.Name = "panellateral";
            this.panellateral.Size = new System.Drawing.Size(200, 668);
            this.panellateral.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 578);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 50);
            this.button6.TabIndex = 10;
            this.button6.Text = "Reporte";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 528);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "Registrar Motorizado";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Submenudeudas
            // 
            this.Submenudeudas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
            this.Submenudeudas.Controls.Add(this.button11);
            this.Submenudeudas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Submenudeudas.Location = new System.Drawing.Point(0, 484);
            this.Submenudeudas.Name = "Submenudeudas";
            this.Submenudeudas.Size = new System.Drawing.Size(200, 44);
            this.Submenudeudas.TabIndex = 9;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(200, 41);
            this.button11.TabIndex = 0;
            this.button11.Text = "Registrar";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 434);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "Deudas";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Submenuegreso
            // 
            this.Submenuegreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
            this.Submenuegreso.Controls.Add(this.button9);
            this.Submenuegreso.Controls.Add(this.button10);
            this.Submenuegreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.Submenuegreso.Location = new System.Drawing.Point(0, 347);
            this.Submenuegreso.Name = "Submenuegreso";
            this.Submenuegreso.Size = new System.Drawing.Size(200, 87);
            this.Submenuegreso.TabIndex = 8;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(0, 41);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(200, 43);
            this.button9.TabIndex = 1;
            this.button9.Text = "Busqueda";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(200, 41);
            this.button10.TabIndex = 0;
            this.button10.Text = "Registrar";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Egreso";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelsubmenusocio
            // 
            this.panelsubmenusocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
            this.panelsubmenusocio.Controls.Add(this.button7);
            this.panelsubmenusocio.Controls.Add(this.btnactualizarsocio);
            this.panelsubmenusocio.Controls.Add(this.btnagregarsocio);
            this.panelsubmenusocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubmenusocio.Location = new System.Drawing.Point(0, 180);
            this.panelsubmenusocio.Name = "panelsubmenusocio";
            this.panelsubmenusocio.Size = new System.Drawing.Size(200, 117);
            this.panelsubmenusocio.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(0, 76);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(200, 41);
            this.button7.TabIndex = 2;
            this.button7.Text = "Listar";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnactualizarsocio
            // 
            this.btnactualizarsocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnactualizarsocio.FlatAppearance.BorderSize = 0;
            this.btnactualizarsocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizarsocio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnactualizarsocio.Location = new System.Drawing.Point(0, 38);
            this.btnactualizarsocio.Name = "btnactualizarsocio";
            this.btnactualizarsocio.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnactualizarsocio.Size = new System.Drawing.Size(200, 38);
            this.btnactualizarsocio.TabIndex = 1;
            this.btnactualizarsocio.Text = "Editar";
            this.btnactualizarsocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizarsocio.UseVisualStyleBackColor = true;
            this.btnactualizarsocio.Click += new System.EventHandler(this.btnactualizarsocio_Click);
            // 
            // btnagregarsocio
            // 
            this.btnagregarsocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnagregarsocio.FlatAppearance.BorderSize = 0;
            this.btnagregarsocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarsocio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnagregarsocio.Location = new System.Drawing.Point(0, 0);
            this.btnagregarsocio.Name = "btnagregarsocio";
            this.btnagregarsocio.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnagregarsocio.Size = new System.Drawing.Size(200, 38);
            this.btnagregarsocio.TabIndex = 0;
            this.btnagregarsocio.Text = "Registrar";
            this.btnagregarsocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregarsocio.UseVisualStyleBackColor = true;
            this.btnagregarsocio.Click += new System.EventHandler(this.btnagregarsocio_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Socio";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panelsubmenu
            // 
            this.panelsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
            this.panelsubmenu.Controls.Add(this.btnsub2);
            this.panelsubmenu.Controls.Add(this.btnsub1);
            this.panelsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubmenu.Location = new System.Drawing.Point(0, 50);
            this.panelsubmenu.Name = "panelsubmenu";
            this.panelsubmenu.Size = new System.Drawing.Size(200, 80);
            this.panelsubmenu.TabIndex = 5;
            // 
            // btnsub2
            // 
            this.btnsub2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsub2.FlatAppearance.BorderSize = 0;
            this.btnsub2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsub2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsub2.Location = new System.Drawing.Point(0, 38);
            this.btnsub2.Name = "btnsub2";
            this.btnsub2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnsub2.Size = new System.Drawing.Size(200, 38);
            this.btnsub2.TabIndex = 1;
            this.btnsub2.Text = "Registrar";
            this.btnsub2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsub2.UseVisualStyleBackColor = true;
            this.btnsub2.Click += new System.EventHandler(this.btnsub2_Click);
            // 
            // btnsub1
            // 
            this.btnsub1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsub1.FlatAppearance.BorderSize = 0;
            this.btnsub1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsub1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsub1.Location = new System.Drawing.Point(0, 0);
            this.btnsub1.Name = "btnsub1";
            this.btnsub1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnsub1.Size = new System.Drawing.Size(200, 38);
            this.btnsub1.TabIndex = 0;
            this.btnsub1.Text = "Lista de multas";
            this.btnsub1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsub1.UseVisualStyleBackColor = true;
            this.btnsub1.Click += new System.EventHandler(this.btnsub1_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.Location = new System.Drawing.Point(0, 0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(200, 50);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Pagos de multas";
            this.btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // panelcabecera
            // 
            this.panelcabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.panelcabecera.Controls.Add(this.label1);
            this.panelcabecera.Controls.Add(this.pictureBox1);
            this.panelcabecera.Controls.Add(this.button1);
            this.panelcabecera.Controls.Add(this.btnmin);
            this.panelcabecera.Controls.Add(this.btnmax);
            this.panelcabecera.Controls.Add(this.btncerrar);
            this.panelcabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcabecera.Location = new System.Drawing.Point(0, 0);
            this.panelcabecera.Name = "panelcabecera";
            this.panelcabecera.Size = new System.Drawing.Size(1200, 32);
            this.panelcabecera.TabIndex = 3;
            this.panelcabecera.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcabecera_Paint);
            this.panelcabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelcabecera_MouseMove_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ASOCIACION DE TRANSPORTE DE MOTO TAXI  EL PALMAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1129, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 26);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.FlatAppearance.BorderSize = 0;
            this.btnmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(1092, 3);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(31, 26);
            this.btnmin.TabIndex = 2;
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click_1);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.FlatAppearance.BorderSize = 0;
            this.btnmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmax.Image = ((System.Drawing.Image)(resources.GetObject("btnmax.Image")));
            this.btnmax.Location = new System.Drawing.Point(1129, 3);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(31, 26);
            this.btnmax.TabIndex = 1;
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1166, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(31, 26);
            this.btncerrar.TabIndex = 0;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click_1);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelprincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panelprincipal.ResumeLayout(false);
            this.panellateral.ResumeLayout(false);
            this.Submenudeudas.ResumeLayout(false);
            this.Submenuegreso.ResumeLayout(false);
            this.panelsubmenusocio.ResumeLayout(false);
            this.panelsubmenu.ResumeLayout(false);
            this.panelcabecera.ResumeLayout(false);
            this.panelcabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.Panel panelcentral;
        private System.Windows.Forms.Panel panellateral;
        private System.Windows.Forms.Panel panelcabecera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelsubmenu;
        private System.Windows.Forms.Button btnsub2;
        private System.Windows.Forms.Button btnsub1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelsubmenusocio;
        private System.Windows.Forms.Button btnactualizarsocio;
        private System.Windows.Forms.Button btnagregarsocio;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel Submenudeudas;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel Submenuegreso;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

