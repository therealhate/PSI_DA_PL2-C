using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ICantina_v1
{
    public partial class MenusForm : Form
    {
        // Lista de menus para a cantina
        private List<string> menus = new List<string>
        {
            "Carne de Vaca com Batatas",
            "Frango Grelhado",
            "Salada de Vegetais",
            "Carne de Porco com Arroz",
            "Peixe Assado",
            "Lasanha Vegetariana"
        };

        public MenusForm()
        {
            InitializeComponent();
            // Inicializa a lista de menus na ListBox
            lstMenus.DataSource = menus;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCarne_Click(object sender, EventArgs e)
        {
            // Filtra apenas os menus de carne
            List<string> carneMenus = new List<string>();
            foreach (var menu in menus)
            {
                if (menu.Contains("Carne"))
                {
                    carneMenus.Add(menu);
                }
            }

            // Atualiza a ListBox para mostrar apenas os menus de carne
            lstMenus.DataSource = carneMenus;
        }

        private void btn_peixe_Click(object sender, EventArgs e)
        {
            // Filtra apenas os menus de carne
            List<string> peixeMenus = new List<string>();
            foreach (var menu in menus)
            {
                if (menu.Contains("Peixe"))
                {
                    peixeMenus.Add(menu);
                }
            }

            // Atualiza a ListBox para mostrar apenas os menus de carne
            lstMenus.DataSource = peixeMenus;
        }

        private void btn_vegan_Click(object sender, EventArgs e)
        {
            // Filtra apenas os menus de carne
            List<string> veganMenus = new List<string>();
            foreach (var menu in menus)
            {
                if (menu.Contains("Vegan") || menu.Contains("Vegetariana") || menu.Contains("Vegetais"))
                {
                    veganMenus.Add(menu);
                }
            }

            // Atualiza a ListBox para mostrar apenas os menus de carne
            lstMenus.DataSource = veganMenus;
        }
    }
}
