using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICantina_v1.Models;

namespace ICantina_v1.Views
{
    public partial class menus : Form
    {
        private List<CantinaMenu> listaMenus;

        public menus()
        {
            InitializeComponent();
            listaMenus = new List<CantinaMenu>();
        }

        // Seus outros métodos existentes aqui...

        public List<CantinaMenu> ObterMenusDisponiveis()
        {
            return listaMenus;
        }

        private void MenusForm_Load(object sender, EventArgs e)
        {
            CarregarMenus();
        }

        private void CarregarMenus()
        {
            try
            {
                if (File.Exists("menus.txt"))
                {
                    using (StreamReader reader = new StreamReader("menus.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] dadosMenu = line.Split(',');
                            if (dadosMenu.Length == 2) // Supondo que o arquivo tenha nome e tipo separados por vírgula
                            {
                                var menu = new CantinaMenu
                                {
                                    Nome = dadosMenu[0],
                                    Tipo = dadosMenu[1] // Atribuir o tipo
                                };
                                listaMenus.Add(menu);
                            }
                        }
                    }
                    PreencherListBox(); // Preencher a lista com todos os menus
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar menus: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherListBox()
        {
            lstMenus.Items.Clear();
            foreach (var menu in listaMenus)
            {
                lstMenus.Items.Add($"{menu.Nome}");
            }
        }

        private void CriarMenu()
        {
            var novoMenu = new CantinaMenu
            {
                Nome = txt_nome.Text,
                Tipo = combo_TipoMenu.SelectedItem.ToString()
            };

            listaMenus.Add(novoMenu);
            SalvarMenus();
            PreencherListBox();
        }

        private void SalvarMenus()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("menus.txt"))
                {
                    foreach (var menu in listaMenus)
                    {
                        writer.WriteLine($"{menu.Nome},{menu.Tipo}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar menus: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncarne_Click(object sender, EventArgs e)
        {
            FiltrarMenus("Carne");
        }

        private void btnpeixe_Click(object sender, EventArgs e)
        {
            FiltrarMenus("Peixe");
        }

        private void btnvegan_Click(object sender, EventArgs e)
        {
            FiltrarMenus("Vegetariano");
        }

        private void FiltrarMenus(string tipo)
        {
            // Limpa a lista atual
            lstMenus.Items.Clear();

            // Filtra os menus pelo tipo selecionado
            foreach (var menu in listaMenus)
            {
                if (menu.Tipo == tipo)
                {
                    lstMenus.Items.Add($"{menu.Nome}");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CriarMenu();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            lstMenus.Items.Clear();
            foreach (var menu in listaMenus)
            {
                lstMenus.Items.Add($"{menu.Nome}");
            }
        }

        public void ExibirMenusPorTipo(string tipo)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var menu in listaMenus.Where(m => m.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase)))
            {
                sb.AppendLine($"{menu.Nome} - {menu.Tipo}");
            }

            if (sb.Length == 0)
            {
                sb.AppendLine("Nenhum menu encontrado.");
            }

            MessageBox.Show(sb.ToString(), $"Menus de {tipo}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
