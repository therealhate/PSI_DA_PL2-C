using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICantina_v1
{
    public partial class semana : Form
    {
        private int deslocamentoSemana = 0; // Variável para rastrear o deslocamento da semana atual
        private List<string> pratos; // Armazena os pratos disponíveis

        public semana()
        {
            InitializeComponent();
            AtualizarSemanaAtualEDataDosDias();
            CarregarPratosDisponiveis();
            MostrarPratosNaSemana();
        }

        private List<string> LerPratosDoArquivo(string caminhoDoArquivo)
        {
            var pratos = new List<string>();

            // Verifica se o arquivo existe
            if (System.IO.File.Exists(caminhoDoArquivo))
            {
                var linhas = System.IO.File.ReadAllLines(caminhoDoArquivo);
                foreach (var linha in linhas)
                {
                    var partes = linha.Split(','); // Assume que cada linha é dividida por vírgulas
                    if (partes.Length > 0)
                    {
                        pratos.Add(partes[0].Trim()); // Adiciona o nome do prato, que está na primeira posição
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo de menus não encontrado.");
            }

            return pratos;
        }

        private void CarregarPratosDisponiveis()
        {
            // Constrói o caminho para o arquivo menus.txt relativo ao diretório de execução do aplicativo
            string caminhoDoArquivo = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "menus.txt");
            pratos = LerPratosDoArquivo(caminhoDoArquivo);
        }

        private void MostrarPratosNaSemana()
        {
            if (pratos == null || pratos.Count == 0)
            {
                MessageBox.Show("Nenhum prato disponível para exibição.");
                return;
            }

            Random random = new Random();
            var pratosAleatorios = pratos.OrderBy(x => random.Next()).Take(6).ToList();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            listBox1.Items.Add(QuebrarTexto(pratosAleatorios[0], listBox1));
            listBox2.Items.Add(QuebrarTexto(pratosAleatorios[1], listBox2));
            listBox3.Items.Add(QuebrarTexto(pratosAleatorios[2], listBox3));
            listBox4.Items.Add(QuebrarTexto(pratosAleatorios[3], listBox4));
            listBox5.Items.Add(QuebrarTexto(pratosAleatorios[4], listBox5));
            listBox6.Items.Add(QuebrarTexto(pratosAleatorios[5], listBox6));
        }

        private string QuebrarTexto(string texto, ListBox listBox)
        {
            // Estimativa da largura média de um caractere, pode ser ajustada conforme necessário
            int larguraCaracter = 7;
            int larguraListBox = listBox.Width;
            int maxCharsPorLinha = larguraListBox / larguraCaracter;

            if (texto.Length <= maxCharsPorLinha)
                return texto;

            var linhas = new List<string>();
            for (int i = 0; i < texto.Length; i += maxCharsPorLinha)
            {
                if (i + maxCharsPorLinha > texto.Length)
                    linhas.Add(texto.Substring(i));
                else
                    linhas.Add(texto.Substring(i, maxCharsPorLinha));
            }

            return string.Join(Environment.NewLine, linhas);
        }

        private void AtualizarSemanaAtualEDataDosDias()
        {
            var cultureInfo = CultureInfo.CurrentCulture;
            var dataAtual = DateTime.Now.AddDays(deslocamentoSemana * 7); // Ajusta a data baseada no deslocamento da semana

            var semanaAtual = cultureInfo.Calendar.GetWeekOfYear(dataAtual, cultureInfo.DateTimeFormat.CalendarWeekRule, cultureInfo.DateTimeFormat.FirstDayOfWeek);

            var diaDaSemanaAtual = (int)dataAtual.DayOfWeek;
            var primeiroDiaDaSemana = dataAtual.AddDays(-(diaDaSemanaAtual - (int)DayOfWeek.Monday));
            if (diaDaSemanaAtual == 0)
            {
                primeiroDiaDaSemana = dataAtual.AddDays(-6);
            }

            var ultimoDiaDaSemana = primeiroDiaDaSemana.AddDays(6);

            SemanaAtual.Text = $"Semana: ({primeiroDiaDaSemana.ToString("dd/MM")} - {ultimoDiaDaSemana.ToString("dd/MM")})";

            Segunda.Text = $"Segunda-Feira\nDia {primeiroDiaDaSemana.ToString("dd")}";
            Terca.Text = $"Terça-Feira\nDia {primeiroDiaDaSemana.AddDays(1).ToString("dd")}";
            Quarta.Text = $"Quarta-Feira\nDia {primeiroDiaDaSemana.AddDays(2).ToString("dd")}";
            Quinta.Text = $"Quinta-Feira\nDia {primeiroDiaDaSemana.AddDays(3).ToString("dd")}";
            Sexta.Text = $"Sexta-Feira\nDia {primeiroDiaDaSemana.AddDays(4).ToString("dd")}";
            Sabado.Text = $"Sábado\nDia {primeiroDiaDaSemana.AddDays(5).ToString("dd")}";
        }

        private void ProxSemana_Click(object sender, EventArgs e)
        {
            deslocamentoSemana++; // Move para a próxima semana
            AtualizarSemanaAtualEDataDosDias();
            MostrarPratosNaSemana();
        }

        private void AntSemana_Click(object sender, EventArgs e)
        {
            deslocamentoSemana--; // Move para a semana anterior
            AtualizarSemanaAtualEDataDosDias();
            MostrarPratosNaSemana();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Segunda_Click(object sender, EventArgs e)
        {
        }

        private void Terca_Click(object sender, EventArgs e)
        {
        }

        private void Quarta_Click(object sender, EventArgs e)
        {
        }

        private void Quinta_Click(object sender, EventArgs e)
        {
        }

        private void Sexta_Click(object sender, EventArgs e)
        {
        }

        private void Sabado_Click(object sender, EventArgs e)
        {
        }

        private void SemanaAtual_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Menu_Click(object sender, EventArgs e)
        {
        }

        private void Menu2_Click(object sender, EventArgs e)
        {
        }

        private void Menu3_Click(object sender, EventArgs e)
        {
        }

        private void Menu4_Click(object sender, EventArgs e)
        {
        }

        private void Menu5_Click(object sender, EventArgs e)
        {
        }

        private void Menu6_Click(object sender, EventArgs e)
        {
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void semana_Load(object sender, EventArgs e)
        {

        }
    }
}
