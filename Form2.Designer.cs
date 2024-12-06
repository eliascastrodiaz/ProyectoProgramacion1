namespace Almacén_Virtual_Proyect
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            btnSalir = new Button();
            btnLogin = new Button();
            label1 = new Label();
            btnRegistro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(562, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.Silver;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtContraseña.ForeColor = SystemColors.ControlText;
            txtContraseña.Location = new Point(512, 319);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(259, 28);
            txtContraseña.TabIndex = 23;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Silver;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.ControlText;
            txtUsuario.Location = new Point(512, 235);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(259, 28);
            txtUsuario.TabIndex = 22;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.ForeColor = Color.Black;
            lblContraseña.Location = new Point(512, 278);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(151, 29);
            lblContraseña.TabIndex = 21;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(512, 193);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(109, 29);
            lblUsuario.TabIndex = 20;
            lblUsuario.Text = "Usuario:";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(680, 375);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(162, 53);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "SALIR";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(429, 375);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(218, 53);
            btnLogin.TabIndex = 25;
            btnLogin.Text = "INICIAR SESIÓN";
            btnLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(623, 440);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 26;
            label1.Text = "Registrarse";
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = SystemColors.ActiveCaptionText;
            btnRegistro.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.ForeColor = Color.MistyRose;
            btnRegistro.Location = new Point(622, 472);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(89, 37);
            btnRegistro.TabIndex = 27;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 546);
            Controls.Add(btnRegistro);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnSalir);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private Label lblUsuario;
        private Button btnSalir;
        private Button btnLogin;
        private Label label1;
        private Button btnRegistro;
    }
}