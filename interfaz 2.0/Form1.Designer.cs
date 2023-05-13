namespace interfaz_2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.panelcabecera = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.panellateral = new System.Windows.Forms.Panel();
            this.panelcentral = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelsubmenu = new System.Windows.Forms.Panel();
            this.btnsub1 = new System.Windows.Forms.Button();
            this.btnsub2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelprincipal.SuspendLayout();
            this.panelcabecera.SuspendLayout();
            this.panellateral.SuspendLayout();
            this.panelcentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelsubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panelprincipal.Size = new System.Drawing.Size(800, 450);
            this.panelprincipal.TabIndex = 2;
            this.panelprincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcentro_Paint);
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
            this.panelcabecera.Size = new System.Drawing.Size(800, 32);
            this.panelcabecera.TabIndex = 3;
            this.panelcabecera.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcabecera_Paint);
            this.panelcabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelcabecera_MouseMove_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(729, 3);
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
            this.btnmin.Location = new System.Drawing.Point(692, 3);
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
            this.btnmax.Location = new System.Drawing.Point(729, 3);
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
            this.btncerrar.Location = new System.Drawing.Point(766, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(31, 26);
            this.btncerrar.TabIndex = 0;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click_1);
            // 
            // panellateral
            // 
            this.panellateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.panellateral.Controls.Add(this.button5);
            this.panellateral.Controls.Add(this.button4);
            this.panellateral.Controls.Add(this.button3);
            this.panellateral.Controls.Add(this.button2);
            this.panellateral.Controls.Add(this.panelsubmenu);
            this.panellateral.Controls.Add(this.btn3);
            this.panellateral.Controls.Add(this.btn1);
            this.panellateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellateral.Location = new System.Drawing.Point(0, 32);
            this.panellateral.Name = "panellateral";
            this.panellateral.Size = new System.Drawing.Size(200, 418);
            this.panellateral.TabIndex = 4;
            // 
            // panelcentral
            // 
            this.panelcentral.BackColor = System.Drawing.Color.White;
            this.panelcentral.Controls.Add(this.pictureBox2);
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.Location = new System.Drawing.Point(200, 32);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(600, 418);
            this.panelcentral.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Location = new System.Drawing.Point(0, 0);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btn1.Size = new System.Drawing.Size(200, 50);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Registrar Asociacion";
            this.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn1.UseVisualStyleBackColor = true;
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
            this.btn3.Location = new System.Drawing.Point(0, 50);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(200, 50);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Pagos";
            this.btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
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
            // panelsubmenu
            // 
            this.panelsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
            this.panelsubmenu.Controls.Add(this.btnsub2);
            this.panelsubmenu.Controls.Add(this.btnsub1);
            this.panelsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubmenu.Location = new System.Drawing.Point(0, 100);
            this.panelsubmenu.Name = "panelsubmenu";
            this.panelsubmenu.Size = new System.Drawing.Size(200, 80);
            this.panelsubmenu.TabIndex = 5;
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
            this.btnsub1.Text = "Mensualidad";
            this.btnsub1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsub1.UseVisualStyleBackColor = true;
            this.btnsub1.Click += new System.EventHandler(this.btnsub1_Click);
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
            this.btnsub2.Text = "Faltas";
            this.btnsub2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsub2.UseVisualStyleBackColor = true;
            this.btnsub2.Click += new System.EventHandler(this.btnsub2_Click);
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
            this.button2.Location = new System.Drawing.Point(0, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registrar Socio";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            this.button3.Location = new System.Drawing.Point(0, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Registrar Egreso";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
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
            this.button4.Location = new System.Drawing.Point(0, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "Registrar Deuda";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
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
            this.button5.Location = new System.Drawing.Point(0, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "Registrar Motorizado";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ASOCIACION DE TRANSPORTE DE MOTO TAXI  EL PALMAR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(127, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelprincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panelprincipal.ResumeLayout(false);
            this.panelcabecera.ResumeLayout(false);
            this.panelcabecera.PerformLayout();
            this.panellateral.ResumeLayout(false);
            this.panelcentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelsubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelsubmenu;
        private System.Windows.Forms.Button btnsub2;
        private System.Windows.Forms.Button btnsub1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

