namespace Modulo_RRH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Login = new Button();
            Cerrar = new Button();
            lblMensaje = new Label();
            txtContrasenia = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(166, 124, 82);
            Login.Font = new Font("Segoe UI", 10F);
            Login.ForeColor = SystemColors.HighlightText;
            Login.Location = new Point(658, 332);
            Login.Name = "Login";
            Login.Size = new Size(94, 36);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.FromArgb(166, 124, 82);
            Cerrar.Font = new Font("Segoe UI", 10F);
            Cerrar.ForeColor = SystemColors.ControlLightLight;
            Cerrar.Location = new Point(818, 332);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(94, 36);
            Cerrar.TabIndex = 1;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(667, 399);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(15, 20);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "-";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(657, 269);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(254, 27);
            txtContrasenia.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(658, 206);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(254, 27);
            txtUsuario.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(626, 471);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(658, 183);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(657, 246);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(677, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 228, 195);
            ClientSize = new Size(950, 468);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsuario);
            Controls.Add(txtContrasenia);
            Controls.Add(lblMensaje);
            Controls.Add(Cerrar);
            Controls.Add(Login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private Button Cerrar;
        private Label lblMensaje;
        private TextBox txtContrasenia;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}
