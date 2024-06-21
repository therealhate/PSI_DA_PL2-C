using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ICantina_v1.Models;

namespace ICantina_v1.Views
{
    public partial class multas : Form
    {
        public multas(List<Reservation> reservasExpiradas)
        {
            InitializeComponent();
            PreencherListBox(reservasExpiradas);
        }

        private void multas_Load(object sender, EventArgs e)
        {
            //cenas
        }

        private void PreencherListBox(List<Reservation> reservasExpiradas)
        {
            listBox_multa.Items.Clear();
            foreach (var reserva in reservasExpiradas)
            {
                listBox_multa.Items.Add($"{reserva.Client} - {reserva.Dia.ToShortDateString()} - Expirou");
            }
        }

        private void btn_pagarMulta_Click(object sender, EventArgs e)
        {

        }
    }
}
