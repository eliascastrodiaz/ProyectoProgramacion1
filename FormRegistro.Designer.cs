namespace Almacén_Virtual_Proyect
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtConfirmarContraseña = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(554, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(445, 241);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(445, 293);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(447, 351);
            label3.Name = "label3";
            label3.Size = new Size(185, 22);
            label3.TabIndex = 4;
            label3.Text = "Confimar Contraseña";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(554, 424);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(89, 39);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(638, 241);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 29);
            txtUsuario.TabIndex = 6;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtContraseña.Location = new Point(638, 303);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 29);
            txtContraseña.TabIndex = 7;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirmarContraseña.Location = new Point(638, 351);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(100, 29);
            txtConfirmarContraseña.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(668, 428);
            button1.Name = "button1";
            button1.Size = new Size(94, 35);
            button1.TabIndex = 9;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 512);
            Controls.Add(button1);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormRegistro";
            Text = "FormRegistro";
            WindowState = FormWindowState.Maximized;
            Load += FormRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private TextBox txtConfirmarContraseña;
        private Button button1;
    }
}