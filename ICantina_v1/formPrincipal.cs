using ICantina_v1;
using ICantina_v1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class formPrincipal : System.Windows.Forms.Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

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

        private void btn_semanas_Click_1(object sender, EventArgs e)
        {
            ShowForm(new semana());
        }

        private void btn_menus_Click(object sender, EventArgs e)
        {
            ShowForm(new MenusForm());
        }

        private void btn_reservas_Click(object sender, EventArgs e)
        {
            ShowForm(new reservas());
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ShowForm(new clientes());
        }

        private void btn_multas_Click(object sender, EventArgs e)
        {
            ShowForm(new multas());
        }
    }
}
