using ICantina_v1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ICantina_v1.Views
{
    public partial class formPrincipal : Form
    {
        // Propriedade para receber o nome do utilizador
        public string NomeUtilizador { get; set; }

        private List<Reservation> listaReservas;

        public formPrincipal()
        {
            InitializeComponent();
            listaReservas = new List<Reservation>();
            CarregarReservas();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            ShowForm(new menus());
        }

        private void btn_reservas_Click(object sender, EventArgs e)
        {
            exibirReservas formReservas = new exibirReservas(listaReservas);
            ShowForm(formReservas);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ShowForm(new clientes());
        }

        private void btn_multas_Click(object sender, EventArgs e)
        {
            // Filtrar reservas expiradas
            List<Reservation> reservasExpiradas = listaReservas.FindAll(reserva => reserva.Dia < DateTime.Now);
            ShowForm(new multas(reservasExpiradas)); // Passar a lista de reservas expiradas para o formulário de multas
        }

        private void btn_mudarUser_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário FormUtilizadores
            FormUtilizadores formUtilizadores = new FormUtilizadores();

            // Mostra o formulário FormUtilizadores como um diálogo modal
            if (formUtilizadores.ShowDialog() == DialogResult.OK)
            {
                // Obtém o nome do utilizador selecionado
                NomeUtilizador = formUtilizadores.NomeUtilizador;

                // Atualiza a Label com o nome do utilizador
                user.Text = NomeUtilizador;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ShowForm(new semana());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
