
namespace Control_de_Vemta_de_Boletos
{
    partial class frmCine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCine));
            this.label1 = new System.Windows.Forms.Label();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbEdad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.image_Niño = new System.Windows.Forms.PictureBox();
            this.JovenII = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.J2 = new System.Windows.Forms.PictureBox();
            this.AdultoI = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Niño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JovenII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.J2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdultoI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Venta de boletos";
            // 
            // lvRegistro
            // 
            this.lvRegistro.BackColor = System.Drawing.SystemColors.MenuText;
            this.lvRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvRegistro.ForeColor = System.Drawing.SystemColors.Window;
            this.lvRegistro.GridLines = true;
            this.lvRegistro.HideSelection = false;
            this.lvRegistro.Location = new System.Drawing.Point(71, 170);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(628, 144);
            this.lvRegistro.TabIndex = 1;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Categoria";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio Unit.";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cant";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SubTotal";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Descuento";
            this.columnHeader5.Width = 114;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Importe";
            this.columnHeader6.Width = 107;
            // 
            // brnMostrar
            // 
            this.brnMostrar.Location = new System.Drawing.Point(65, 320);
            this.brnMostrar.Name = "brnMostrar";
            this.brnMostrar.Size = new System.Drawing.Size(149, 33);
            this.brnMostrar.TabIndex = 3;
            this.brnMostrar.Text = "Mostrar Estadisticas";
            this.brnMostrar.UseVisualStyleBackColor = true;
            this.brnMostrar.Click += new System.EventHandler(this.brnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(818, 466);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(699, 101);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 57);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Razon social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(61, 57);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(517, 20);
            this.txtRazonSocial.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.cbEdad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(61, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de boletos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(380, 32);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(101, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(257, 35);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(83, 17);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "lblCategoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(147, 35);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(62, 17);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "lblPrecio";
            // 
            // cbEdad
            // 
            this.cbEdad.FormattingEnabled = true;
            this.cbEdad.Items.AddRange(new object[] {
            "Niño",
            "JovenI",
            "JovenII",
            "AdultoI",
            "AdultoII"});
            this.cbEdad.Location = new System.Drawing.Point(4, 32);
            this.cbEdad.Name = "cbEdad";
            this.cbEdad.Size = new System.Drawing.Size(121, 21);
            this.cbEdad.TabIndex = 14;
            this.cbEdad.SelectedIndexChanged += new System.EventHandler(this.cbEdad_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Edad";
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.BackColor = System.Drawing.SystemColors.InfoText;
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvEstadisticas.ForeColor = System.Drawing.SystemColors.Window;
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.HideSelection = false;
            this.lvEstadisticas.Location = new System.Drawing.Point(65, 359);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(724, 144);
            this.lvEstadisticas.TabIndex = 10;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Condicion";
            this.columnHeader7.Width = 343;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Valor";
            this.columnHeader8.Width = 377;
            // 
            // image_Niño
            // 
            this.image_Niño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("image_Niño.BackgroundImage")));
            this.image_Niño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_Niño.Location = new System.Drawing.Point(813, 37);
            this.image_Niño.Name = "image_Niño";
            this.image_Niño.Size = new System.Drawing.Size(170, 185);
            this.image_Niño.TabIndex = 11;
            this.image_Niño.TabStop = false;
            // 
            // JovenII
            // 
            this.JovenII.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JovenII.BackgroundImage")));
            this.JovenII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JovenII.Location = new System.Drawing.Point(813, 37);
            this.JovenII.Name = "JovenII";
            this.JovenII.Size = new System.Drawing.Size(170, 185);
            this.JovenII.TabIndex = 12;
            this.JovenII.TabStop = false;
            // 
            // A2
            // 
            this.A2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A2.BackgroundImage")));
            this.A2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A2.Location = new System.Drawing.Point(813, 41);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(170, 161);
            this.A2.TabIndex = 13;
            this.A2.TabStop = false;
            // 
            // J2
            // 
            this.J2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("J2.BackgroundImage")));
            this.J2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.J2.Location = new System.Drawing.Point(813, 37);
            this.J2.Name = "J2";
            this.J2.Size = new System.Drawing.Size(170, 185);
            this.J2.TabIndex = 14;
            this.J2.TabStop = false;
            // 
            // AdultoI
            // 
            this.AdultoI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdultoI.BackgroundImage")));
            this.AdultoI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdultoI.Location = new System.Drawing.Point(813, 37);
            this.AdultoI.Name = "AdultoI";
            this.AdultoI.Size = new System.Drawing.Size(170, 185);
            this.AdultoI.TabIndex = 15;
            this.AdultoI.TabStop = false;
            // 
            // frmCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 551);
            this.Controls.Add(this.AdultoI);
            this.Controls.Add(this.J2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.JovenII);
            this.Controls.Add(this.image_Niño);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.brnMostrar);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.label1);
            this.Name = "frmCine";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Niño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JovenII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.J2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdultoI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvRegistro;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button brnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvEstadisticas;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cbEdad;
        private System.Windows.Forms.PictureBox image_Niño;
        private System.Windows.Forms.PictureBox JovenII;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox J2;
        private System.Windows.Forms.PictureBox AdultoI;
    }
}

