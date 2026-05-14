namespace PI_Club_Deportivo
{
    partial class frmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            lblTituloInscripcion = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblTipoDni = new Label();
            cboTipoDni = new ComboBox();
            lblNumDoc = new Label();
            txtNumDoc = new TextBox();
            lblFechaNac = new Label();
            lblTel = new Label();
            txtTel = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            chkAptoF = new CheckBox();
            lblTipoCliente = new Label();
            cboTipoCliente = new ComboBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            pbIcono = new PictureBox();
            dtpFechaNac = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // lblTituloInscripcion
            // 
            lblTituloInscripcion.AutoSize = true;
            lblTituloInscripcion.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloInscripcion.Location = new Point(479, 26);
            lblTituloInscripcion.Name = "lblTituloInscripcion";
            lblTituloInscripcion.Size = new Size(240, 46);
            lblTituloInscripcion.TabIndex = 0;
            lblTituloInscripcion.Text = "Inscripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(106, 167);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(124, 27);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "* Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 197);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(384, 34);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(106, 255);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(126, 27);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "* Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(106, 285);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(384, 34);
            txtApellido.TabIndex = 4;
            // 
            // lblTipoDni
            // 
            lblTipoDni.AutoSize = true;
            lblTipoDni.Location = new Point(106, 401);
            lblTipoDni.Name = "lblTipoDni";
            lblTipoDni.Size = new Size(215, 27);
            lblTipoDni.TabIndex = 5;
            lblTipoDni.Text = "* Tipo documento:";
            // 
            // cboTipoDni
            // 
            cboTipoDni.FormattingEnabled = true;
            cboTipoDni.Items.AddRange(new object[] { "DNI (Documento Nacional de Identidad)", "PASAPORTE", "LC (Libreta Cívica)" });
            cboTipoDni.Location = new Point(327, 398);
            cboTipoDni.Name = "cboTipoDni";
            cboTipoDni.Size = new Size(163, 35);
            cboTipoDni.TabIndex = 6;
            // 
            // lblNumDoc
            // 
            lblNumDoc.AutoSize = true;
            lblNumDoc.Location = new Point(509, 401);
            lblNumDoc.Name = "lblNumDoc";
            lblNumDoc.Size = new Size(290, 27);
            lblNumDoc.TabIndex = 7;
            lblNumDoc.Text = "* Número de documento:";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(805, 398);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(300, 34);
            txtNumDoc.TabIndex = 8;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(530, 349);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(269, 27);
            lblFechaNac.TabIndex = 9;
            lblFechaNac.Text = "* Fecha de nacimiento:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(682, 459);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(117, 27);
            lblTel.TabIndex = 11;
            lblTel.Text = "Telefono:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(805, 456);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(300, 34);
            txtTel.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(107, 459);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(232, 27);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Correo electrónico:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(345, 456);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 34);
            txtEmail.TabIndex = 14;
            // 
            // chkAptoF
            // 
            chkAptoF.AutoSize = true;
            chkAptoF.Location = new Point(106, 345);
            chkAptoF.Name = "chkAptoF";
            chkAptoF.Size = new Size(175, 31);
            chkAptoF.TabIndex = 16;
            chkAptoF.Text = "* Apto Físico";
            chkAptoF.UseVisualStyleBackColor = true;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(106, 122);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(165, 27);
            lblTipoCliente.TabIndex = 17;
            lblTipoCliente.Text = "* Tipo cliente:";
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Items.AddRange(new object[] { "Socio", "No Socio" });
            cboTipoCliente.Location = new Point(277, 119);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(213, 35);
            cboTipoCliente.TabIndex = 18;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(107, 592);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(252, 77);
            btnRegistrar.TabIndex = 19;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(467, 592);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(252, 77);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(853, 592);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(252, 77);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pbIcono
            // 
            pbIcono.Image = (Image)resources.GetObject("pbIcono.Image");
            pbIcono.Location = new Point(861, 41);
            pbIcono.Name = "pbIcono";
            pbIcono.Size = new Size(244, 278);
            pbIcono.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcono.TabIndex = 22;
            pbIcono.TabStop = false;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(805, 349);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(300, 34);
            dtpFechaNac.TabIndex = 23;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1182, 753);
            Controls.Add(dtpFechaNac);
            Controls.Add(pbIcono);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(cboTipoCliente);
            Controls.Add(lblTipoCliente);
            Controls.Add(chkAptoF);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTel);
            Controls.Add(lblTel);
            Controls.Add(lblFechaNac);
            Controls.Add(txtNumDoc);
            Controls.Add(lblNumDoc);
            Controls.Add(cboTipoDni);
            Controls.Add(lblTipoDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTituloInscripcion);
            Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmInscripcion";
            Text = "frmInscripcion";
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInscripcion;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblTipoDni;
        private ComboBox cboTipoDni;
        private Label lblNumDoc;
        private TextBox txtNumDoc;
        private Label lblFechaNac;
        private Label lblTel;
        private TextBox txtTel;
        private Label lblEmail;
        private TextBox txtEmail;
        private CheckBox chkAptoF;
        private Label lblTipoCliente;
        private ComboBox cboTipoCliente;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
        private PictureBox pbIcono;
        private DateTimePicker dtpFechaNac;
    }
}