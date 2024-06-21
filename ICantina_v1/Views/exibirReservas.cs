using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ICantina_v1.Models;

namespace ICantina_v1.Views
{
    public partial class exibirReservas : Form
    {
        private List<Reservation> listaReservas;

        public exibirReservas(List<Reservation> reservas)
        {
            InitializeComponent();
            listaReservas = reservas ?? new List<Reservation>();
            CarregarReservas();
            list_reservasFeitas.DrawMode = DrawMode.OwnerDrawFixed;
            list_reservasFeitas.DrawItem += List_reservasFeitas_DrawItem;
            list_reservasFeitas.SelectedIndexChanged += List_reservasFeitas_SelectedIndexChanged;
            btn_eliminarReserva.Click += btn_eliminarReserva_Click; // Adiciona o evento para o botão de eliminar
        }

        private void CarregarReservas()
        {
            try
            {
                // Limpa a lista de reservas antes de carregar do arquivo
                listaReservas.Clear();

                if (File.Exists("reservas.txt"))
                {
                    using (StreamReader reader = new StreamReader("reservas.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] dadosReserva = line.Split(',');
                            if (dadosReserva.Length == 4)
                            {
                                var reserva = new Reservation
                                {
                                    Client = new Client { Nome = dadosReserva[0] },
                                    Dia = DateTime.Parse(dadosReserva[1]),
                                    Menu = dadosReserva[2],
                                    Extras = dadosReserva[3],
                                    IsActive = false // Inicializa como não ativa
                                };
                                listaReservas.Add(reserva);
                            }
                        }
                    }
                    PreencherListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherListBox()
        {
            list_reservasFeitas.Items.Clear();
            foreach (var reserva in listaReservas)
            {
                string status = reserva.Dia < DateTime.Now ? " (Expirada)" : reserva.IsActive ? " (Ativa)" : "";
                list_reservasFeitas.Items.Add($"{reserva.Client.Nome} --- {reserva.Dia.ToShortDateString()} --- Menu: {reserva.Menu} --- Extras: {reserva.Extras} ------ {status}");
            }
        }

        private void List_reservasFeitas_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var reserva = listaReservas[e.Index];
            bool isExpired = reserva.Dia < DateTime.Now;

            // Determine the text color based on whether the item is selected and expired status
            Brush textBrush;
            if (e.State.HasFlag(DrawItemState.Selected))
            {
                textBrush = isExpired ? Brushes.Black : Brushes.White; // White for non-expired to be readable when selected
            }
            else
            {
                textBrush = isExpired ? Brushes.Black : Brushes.Green; // Green for non-expired when not selected
            }

            // Draw the background
            e.DrawBackground();

            // Draw the text
            e.Graphics.DrawString(list_reservasFeitas.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds);

            // Draw the focus rectangle if the item has focus
            e.DrawFocusRectangle();
        }

        private void List_reservasFeitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_reservasFeitas.SelectedIndex >= 0)
            {
                var reserva = listaReservas[list_reservasFeitas.SelectedIndex];
                bool isExpired = reserva.Dia < DateTime.Now;
                btn_ativarReserva.Enabled = !isExpired;
                btn_eliminarReserva.Enabled = true;
            }
            else
            {
                btn_ativarReserva.Enabled = false;
                btn_eliminarReserva.Enabled = false;
            }
        }

        private void exibirReservas_Load(object sender, EventArgs e)
        {
            // Carregar reservas se necessário
        }

        private void btn_ativarReserva_Click(object sender, EventArgs e)
        {
            if (list_reservasFeitas.SelectedIndex >= 0)
            {
                var reserva = listaReservas[list_reservasFeitas.SelectedIndex];
                reserva.IsActive = true;
                MessageBox.Show($"Reserva de {reserva.Client.Nome} ativada.", "Reserva Ativada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PreencherListBox();
            }
        }

        private void btn_eliminarReserva_Click(object sender, EventArgs e)
        {
            if (list_reservasFeitas.SelectedIndex >= 0)
            {
                var reserva = listaReservas[list_reservasFeitas.SelectedIndex];
                var result = MessageBox.Show($"Tem certeza que deseja eliminar a reserva de {reserva.Client.Nome}?", "Eliminar Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    listaReservas.RemoveAt(list_reservasFeitas.SelectedIndex);
                    MessageBox.Show($"Reserva de {reserva.Client.Nome} eliminada.", "Reserva Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PreencherListBox();
                    SalvarReservas();
                }
            }
        }

        private void SalvarReservas()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("reservas.txt"))
                {
                    foreach (var reserva in listaReservas)
                    {
                        writer.WriteLine($"{reserva.Client.Nome},{reserva.Dia},{reserva.Menu},{reserva.Extras}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
