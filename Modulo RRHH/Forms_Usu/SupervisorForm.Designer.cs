namespace Modulo_RRH.Forms_Usu
{
    partial class SupervisorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupervisorForm));
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(166, 124, 82);
            button6.Font = new Font("Segoe UI", 10F);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(550, 437);
            button6.Name = "button6";
            button6.Size = new Size(242, 38);
            button6.TabIndex = 11;
            button6.Text = "Gestion de horarios";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(166, 124, 82);
            button5.Font = new Font("Segoe UI", 10F);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(550, 393);
            button5.Name = "button5";
            button5.Size = new Size(242, 38);
            button5.TabIndex = 10;
            button5.Text = "Evaluaciones de desempeño";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(166, 124, 82);
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(550, 349);
            button4.Name = "button4";
            button4.Size = new Size(242, 38);
            button4.TabIndex = 9;
            button4.Text = "Generar reportes basicos";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(166, 124, 82);
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(550, 305);
            button3.Name = "button3";
            button3.Size = new Size(242, 38);
            button3.TabIndex = 8;
            button3.Text = "Gestion de asistencias";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(166, 124, 82);
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(550, 261);
            button1.Name = "button1";
            button1.Size = new Size(242, 38);
            button1.TabIndex = 6;
            button1.Text = "Ver empleados";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(550, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(242, 147);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(550, 217);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 13;
            label1.Text = "Bienvenido Cesar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 519);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // SupervisorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 228, 195);
            ClientSize = new Size(846, 519);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupervisorForm";
            Text = "SupervisorForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}