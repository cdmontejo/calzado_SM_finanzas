namespace Modulo_RRH.Forms_Usu
{
    partial class DueñoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DueñoForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(166, 124, 82);
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(492, 265);
            button1.Name = "button1";
            button1.Size = new Size(257, 44);
            button1.TabIndex = 0;
            button1.Text = "Administracion de emplados";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(166, 124, 82);
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(492, 415);
            button2.Name = "button2";
            button2.Size = new Size(257, 44);
            button2.TabIndex = 1;
            button2.Text = "Control de permisos y accesos";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(166, 124, 82);
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(492, 365);
            button3.Name = "button3";
            button3.Size = new Size(257, 44);
            button3.TabIndex = 2;
            button3.Text = "Generar reportes avanzados";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(166, 124, 82);
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(492, 315);
            button4.Name = "button4";
            button4.Size = new Size(257, 44);
            button4.TabIndex = 3;
            button4.Text = "Gestion financiera";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(492, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 148);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(492, 217);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 14;
            label1.Text = "Bienvenido Cesar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // DueñoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 228, 195);
            ClientSize = new Size(800, 505);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DueñoForm";
            Text = "DueñoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}