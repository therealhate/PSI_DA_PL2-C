using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            listaReservas = new List<Reservation>();
            CarregarReservas();
            list_reservasFeitas.DrawMode = DrawMode.OwnerDrawFixed;
            list_reservasFeitas.DrawItem += List_reservasFeitas_DrawItem;
            list_reservasFeitas.SelectedIndexChanged += List_reservasFeitas_SelectedIndexChanged;
        }

        private void CarregarReservas()
        {
            try
            {
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
                                    Extras = dadosReserva[3]
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
                string status = reserva.Dia < DateTime.Now ? " (Expirada)" : "";
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
            }
            else
            {
                btn_ativarReserva.Enabled = false;
            }
        }

        private void exibirReservas_Load(object sender, EventArgs e)
        {
            // Carregar reservas se necessário
        }

        private void btn_ativarReserva_Click(object sender, EventArgs e)
        {
            // Implementar funcionalidade para ativar a reserva
        }
    }
}
