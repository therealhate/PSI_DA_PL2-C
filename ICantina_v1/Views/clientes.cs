using ICantina_v1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICantina_v1.Views
{
    public partial class clientes : Form
    {
        private List<Client> listaClientes;

        private void Form_Load(object sender, EventArgs e)
        {
            // Inicialize o ComboBox com os tipos de cliente
            combo_tipoCliente.Items.Add("Professor");
            combo_tipoCliente.Items.Add("Aluno");
            combo_tipoCliente.Items.Add("Funcionário");
        }

        public clientes()
        {
            this.Load += new System.EventHandler(this.Form_Load);
            InitializeComponent();
            listaClientes = new List<Client>();
            CarregarClientes(); // Carrega os clientes ao iniciar o formulário
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            // Código que deve ser executado quando o formulário carregar
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Verifique se um item foi selecionado no ComboBox
            if (combo_tipoCliente.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de cliente.");
                return;
            }

            // Obter o tipo de cliente selecionado
            string tipoClienteSelecionado = combo_tipoCliente.SelectedItem.ToString();

            // Mapear o tipo de cliente selecionado para um valor numérico
            int tipoClienteValue;
            switch (tipoClienteSelecionado)
            {
                case "Professor":
                    tipoClienteValue = 0;
                    break;
                case "Aluno":
                    tipoClienteValue = 1;
                    break;
                case "Funcionário":
                    tipoClienteValue = 2;
                    break;
                default:
                    tipoClienteValue = 0; // Valor padrão ou tratamento de erro
                    break;
            }

            // Criar o objeto Client com os dados dos TextBoxes e tipo de cliente
            var cliente = new Client
            {
                Num = txt_num.Text,
                Nome = txt_nome.Text,
                Email = txt_email.Text,
                Tipo = tipoClienteValue,
                saldo = txt_saldo.Text,
            };

            // Adicionar o cliente à lista
            listaClientes.Add(cliente);

            // Atualizar o ListBox
            AtualizarListBox();

            // Salvar os clientes após adicionar um novo cliente
            SalvarClientes();
            txt_num.Clear();
            txt_email.Clear();
            txt_nome.Clear();
            txt_saldo.Clear();
        }

        private void SalvarClientes()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("clientes.txt"))
                {
                    foreach (var cliente in listaClientes)
                    {
                        writer.WriteLine($"{cliente.Num},{cliente.Nome},{cliente.Email}, Saldo:{cliente.saldo}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarClientes()
        {
            try
            {
                if (File.Exists("clientes.txt"))
                {
                    using (StreamReader reader = new StreamReader("clientes.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] dadosCliente = line.Split(',');
                            if (dadosCliente.Length == 4)
                            {
                                var cliente = new Client
                                {
                                    Num = dadosCliente[0],
                                    Nome = dadosCliente[1],
                                    Email = dadosCliente[2],
                                    saldo = dadosCliente[3]
                                };
                                listaClientes.Add(cliente);
                            }
                        }
                    }

                    // Atualizar o ListBox após carregar os clientes
                    AtualizarListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListBox()
        {
            listBox_clientes.Items.Clear();
            foreach (var cliente in listaClientes)
            {
                listBox_clientes.Items.Add(cliente.ToString());
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Verificar se algum cliente está selecionado
            if (listBox_clientes.SelectedIndex != -1)
            {
                // Remover o cliente selecionado da lista
                listaClientes.RemoveAt(listBox_clientes.SelectedIndex);

                // Atualizar o ListBox
                AtualizarListBox();

                // Salvar os clientes após remover um cliente
                SalvarClientes();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void combo_tipoCliente_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btn_marcarReserva_Click(object sender, EventArgs e)
        {
            if (listBox_clientes.SelectedIndex != -1)
            {
                var selectedClient = listaClientes[listBox_clientes.SelectedIndex];
                var formReservas = new Views.reservar(selectedClient);
                formReservas.Show();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para marcar a reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números, ponto decimal e teclas de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Ignora o caractere digitado
            }

            // Permitir apenas um ponto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Ignora o segundo ponto decimal
            }
        }

        private void listBox_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
