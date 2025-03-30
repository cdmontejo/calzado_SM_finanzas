namespace Modulo_RRH.Forms_Usu.opciones_super
{
    partial class VerEmpleadosForm
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
            dgvEmpleados = new DataGridView();
            btnActualizar = new Button();
            btnCerrar = new Button();
            txtBuscar = new TextBox();
            cbxArea = new ComboBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.GridColor = SystemColors.Window;
            dgvEmpleados.Location = new Point(34, 110);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(388, 347);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(166, 124, 82);
            btnActualizar.Font = new Font("Segoe UI", 10F);
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(451, 163);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(211, 38);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(166, 124, 82);
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(451, 274);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(106, 36);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(34, 64);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(388, 27);
            txtBuscar.TabIndex = 3;
            // 
            // cbxArea
            // 
            cbxArea.FormattingEnabled = true;
            cbxArea.Location = new Point(451, 37);
            cbxArea.Name = "cbxArea";
            cbxArea.Size = new Size(211, 28);
            cbxArea.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(166, 124, 82);
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(451, 110);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(211, 38);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(166, 124, 82);
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(451, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(211, 38);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 7;
            label1.Text = "Ver Empleados";
            // 
            // VerEmpleadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 228, 195);
            ClientSize = new Size(697, 495);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(cbxArea);
            Controls.Add(txtBuscar);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvEmpleados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerEmpleadosForm";
            Text = "VerEmpleadosForm";
            Load += VerEmpleadosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btnActualizar;
        private Button btnCerrar;
        private TextBox txtBuscar;
        private ComboBox cbxArea;
        private Button btnBuscar;
        private Button btnEliminar;
        private Label label1;
    }
}