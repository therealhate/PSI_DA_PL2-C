using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICantina_v1.Views
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm(new clientes_add());
        }
    }
}
