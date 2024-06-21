using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ICantina_v1.Models
{
    public class Client
    {
        public string Num { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Tipo { get; set; }
        public string saldo { get; set; }

        public string TipoCliente
        {
            get
            {
                switch (Tipo)
                {
                    case 0:
                        return "Professor";
                    case 1:
                        return "Aluno";
                    case 2:
                        return "Funcionário";
                    default:
                        return "Desconhecido";
                }
            }
        }

        public override string ToString()
        {
            return $"{TipoCliente} - {Num} - {Nome} - {Email} - {saldo}";
        }
    }




}
