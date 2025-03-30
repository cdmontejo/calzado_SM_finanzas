using Modulo_RRH.Forms_Usu.opciones_super;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_RRH.Forms_Usu
{
    public partial class SupervisorForm : Form
    {
        public SupervisorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerEmpleadosForm verEmpleados = new VerEmpleadosForm();
            verEmpleados.ShowDialog();
        }
    }
}
