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
            // Ações ao carregar o formulário
        }

        private void PreencherListBox(List<Reservation> reservasExpiradas)
        {
            listBox_multa.Items.Clear();
            foreach (var reserva in reservasExpiradas)
            {
                listBox_multa.Items.Add($"{reserva.Client.Nome} - {reserva.Dia.ToShortDateString()} - Expirou");
            }
        }

        private void btn_pagarMulta_Click(object sender, EventArgs e)
        {
            // Verificar se algum item está selecionado na listBox_multa
            if (listBox_multa.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma multa para pagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Converter o item selecionado para string
            string selectedMultaString = listBox_multa.SelectedItem.ToString();

            // Separar a string em suas partes (cliente - data - estado)
            string[] multaParts = selectedMultaString.Split(new string[] { " - " }, StringSplitOptions.None);

            // Validar se a multa foi dividida corretamente
            if (multaParts.Length < 3)
            {
                MessageBox.Show("Erro ao obter a multa selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Extrair informações da multa selecionada
            string clienteNome = multaParts[0];
            string dataMulta = multaParts[1];

            // Simular o pagamento da multa
            // Aqui você pode adicionar a lógica para pagar a multa
            MessageBox.Show($"Multa para o cliente {clienteNome}, referente a {dataMulta}, foi paga com sucesso.", "Pagamento Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Remover a multa da listBox_multa após o pagamento (opcional)
            listBox_multa.Items.Remove(listBox_multa.SelectedItem);
        }

        private void btn_eliminarMulta_Click(object sender, EventArgs e)
        {
            // Verificar se algum item está selecionado na listBox_multa
            if (listBox_multa.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma multa para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar com o usuário se deseja realmente eliminar a multa
            DialogResult result = MessageBox.Show("Tem certeza que deseja eliminar esta multa?", "Confirmar Eliminação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Remover a multa selecionada da listBox_multa
                listBox_multa.Items.Remove(listBox_multa.SelectedItem);

                MessageBox.Show("Multa eliminada com sucesso.", "Eliminação Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação de eliminação cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
