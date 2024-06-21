using ICantina_v1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ICantina_v1.Views;
using System.Linq;

namespace ICantina_v1.Views
{
    public partial class FormUtilizadores : Form
    {
        public string NomeUtilizador { get; set; }
        private List<Utilizador> utilizadores;

        public FormUtilizadores()
        {
            InitializeComponent();
            utilizadores = new List<Utilizador>();
            CarregarUtilizadores();
            AtualizarListBox();
        }

        private void CarregarUtilizadores()
        {
            try
            {
                if (File.Exists("utilizadores.txt"))
                {
                    using (StreamReader reader = new StreamReader("utilizadores.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] dadosUtilizador = line.Split(',');
                            if (dadosUtilizador.Length == 2)
                            {
                                var utilizador = new Utilizador
                                {
                                    Nome = dadosUtilizador[0],
                                    Email = dadosUtilizador[1]
                                };
                                utilizadores.Add(utilizador);
                            }
                        }
                    }
                    // Atualizar o ListBox após carregar os utilizadores
                    AtualizarListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar utilizadores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListBox()
        {
            listBox_funcionarios.Items.Clear();
            foreach (var utilizador in utilizadores)
            {
                // Adicionar o utilizador diretamente como objeto
                listBox_funcionarios.Items.Add(utilizador);
            }
        }

        private void btn_adicionarFuncionario_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text.Trim();
            string email = txt_email.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var novoUtilizador = new Utilizador { Nome = nome, Email = email };
            utilizadores.Add(novoUtilizador);
            AtualizarListBox();
            SalvarUtilizadores();

            // Limpar campos após adicionar
            txt_nome.Clear();
            txt_email.Clear();
        }

        private void SalvarUtilizadores()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("utilizadores.txt"))
                {
                    foreach (var utilizador in utilizadores)
                    {
                        writer.WriteLine($"{utilizador.Nome},{utilizador.Email}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar utilizadores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //SalvarFuncionarios();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (listBox_funcionarios.SelectedIndex != -1)
            {
                utilizadores.RemoveAt(listBox_funcionarios.SelectedIndex);
                AtualizarListBox();
                SalvarUtilizadores();
            }
            else
            {
                MessageBox.Show("Selecione um utilizador para eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            // Verifica se há um utilizador selecionado na listBox_funcionarios
            if (listBox_funcionarios.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um utilizador para entrar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtém o utilizador selecionado (como objeto)
            string nomeUtilizador = listBox_funcionarios.SelectedItem.ToString();

            // Cria uma instância do formulário FormPrincipal
            formPrincipal formPrincipal = Application.OpenForms.OfType<formPrincipal>().FirstOrDefault() ?? new formPrincipal();

            // Define o nome do utilizador no formulário FormPrincipal
            formPrincipal.NomeUtilizador = nomeUtilizador;

            // Exibe o formulário FormPrincipal
            formPrincipal.Show();

            // Esconde o formulário FormUtilizadores
            this.Hide();
        }


    }
}

