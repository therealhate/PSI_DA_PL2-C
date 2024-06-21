using ICantina_v1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ICantina_v1.Views
{
    public partial class reservar : Form
    {
        private Client selectedClient;
        private List<Reservation> listaReservas;

        public reservar()
        {
            InitializeComponent();
            listaReservas = new List<Reservation>();
        }

        public reservar(Client client) : this()
        {
            selectedClient = client;
            lblClientName.Text = $"Cliente: {selectedClient.Nome}";
        }

        private void AtualizarListBox()
        {
            list_reservas.Items.Clear();
            foreach (var reserva in listaReservas)
            {
                list_reservas.Items.Add(reserva.ToString());
            }
        }

        private void reservar_Load(object sender, EventArgs e)
        {
            // Carregar reservas existentes se necessário
        }

        private void SalvarReservas()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("reservas.txt", true)) // true para adicionar ao arquivo existente
                {
                    foreach (var reserva in listaReservas)
                    {
                        writer.WriteLine($"{reserva.Client.Nome},{reserva.Dia.ToShortDateString()},{reserva.Menu},{reserva.Extras}");
                    }
                }
                MessageBox.Show("Reservas salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reservas_Load(object sender, EventArgs e)
        {
            // Adicione o código que deseja executar quando o formulário for carregado.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var reserva = new Reservation
            {
                Client = selectedClient,
                Dia = diaDaReserva.Value,
                Menu = combo_menus.Text,
                Extras = combo_extras.Text
            };

            listaReservas.Add(reserva);
            AtualizarListBox();
        }

        private void btn_salvarReservas_Click(object sender, EventArgs e)
        {
            SalvarReservas();
        }

        private void combo_extras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_extras.SelectedIndex == 0)
            {
                lbl_preco.Text = "3.00€ + 1.00€";
            }else if(combo_extras.SelectedIndex == 1)
            {
                lbl_preco.Text = "3.00€ + 0.50€";
            }else if (combo_extras.SelectedIndex == 2)
            {
                lbl_preco.Text = "3.00€ + 1.50€";
            }else if (combo_extras.SelectedIndex == 3)
            {
                lbl_preco.Text = "3.00€ + 0.50€";
            }
        }

        private void combo_menus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
