namespace PI_Club_Deportivo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btnInscribir = new Button();
            btnCuota = new Button();
            btnCarnet = new Button();
            btnListado = new Button();
            lblSaludo = new Label();
            pbIcon = new PictureBox();
            btnCerrar = new Button();
            btnAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = SystemColors.GradientInactiveCaption;
            btnInscribir.Location = new Point(125, 152);
            btnInscribir.Margin = new Padding(5, 4, 5, 4);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(262, 79);
            btnInscribir.TabIndex = 1;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnCuota
            // 
            btnCuota.BackColor = SystemColors.GradientInactiveCaption;
            btnCuota.Location = new Point(125, 287);
            btnCuota.Margin = new Padding(5, 4, 5, 4);
            btnCuota.Name = "btnCuota";
            btnCuota.Size = new Size(262, 79);
            btnCuota.TabIndex = 2;
            btnCuota.Text = "Cobrar Cuota";
            btnCuota.UseVisualStyleBackColor = false;
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = SystemColors.GradientInactiveCaption;
            btnCarnet.Location = new Point(125, 420);
            btnCarnet.Margin = new Padding(5, 4, 5, 4);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(262, 79);
            btnCarnet.TabIndex = 3;
            btnCarnet.Text = "Emitir Carnet";
            btnCarnet.UseVisualStyleBackColor = false;
            // 
            // btnListado
            // 
            btnListado.BackColor = SystemColors.GradientInactiveCaption;
            btnListado.Location = new Point(125, 558);
            btnListado.Margin = new Padding(5, 4, 5, 4);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(262, 79);
            btnListado.TabIndex = 4;
            btnListado.Text = "Listado Deudores";
            btnListado.UseVisualStyleBackColor = false;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(663, 67);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(0, 27);
            lblSaludo.TabIndex = 5;
            // 
            // pbIcon
            // 
            pbIcon.Image = (Image)resources.GetObject("pbIcon.Image");
            pbIcon.Location = new Point(636, 152);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(438, 345);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 6;
            pbIcon.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.GradientInactiveCaption;
            btnCerrar.Location = new Point(812, 558);
            btnCerrar.Margin = new Padding(5, 4, 5, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(262, 79);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.GradientInactiveCaption;
            btnAdmin.Location = new Point(478, 558);
            btnAdmin.Margin = new Padding(5, 4, 5, 4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(262, 79);
            btnAdmin.TabIndex = 8;
            btnAdmin.Text = "Administración";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Visible = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(btnAdmin);
            Controls.Add(btnCerrar);
            Controls.Add(pbIcon);
            Controls.Add(lblSaludo);
            Controls.Add(btnListado);
            Controls.Add(btnCarnet);
            Controls.Add(btnCuota);
            Controls.Add(btnInscribir);
            Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnInscribir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnInscribir;
        private Button btnCuota;
        private Button btnCarnet;
        private Button btnListado;
        private Label lblSaludo;
        private PictureBox pbIcon;
        private Button btnCerrar;
        private Button btnAdmin;
    }
}