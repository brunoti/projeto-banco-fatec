/*************************************************************************************
Faculdade de Tecnologia de Franca “Doutor Thomaz Novelino” TRABALHO INTERMEDIÁRIO DE LINGUAGEM DE PROGRAMAÇÃO II (C#) - 2015/1
Autor(es):
    BRUNO OLIVEIRA DE PAULA <bruno.oliveirati1@gmail.com> - RGM 000000000000
    RAFEL BORGES DO NASCIMENTO <rborgesdonascimento@gmail.com> - RGM 000000000000
Data de criação do arquivo:
    09/05/2015
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_BrunoOliveiraRafaelBorges {
    public class Cliente {

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }

        public bool SexoMasculino { get; set; }

        public string Telefone { get; set; }

        public Cliente(string nome, string cpf) {
            Nome = nome;
            Cpf = cpf;
        }

        public Cliente(string nome, string cpf, int idade) {
            Nome = nome;
            Cpf = cpf;
            Idade = idade;
        }

        private int idade;

        public int Idade {
            get { return idade; }
            set {
                if (value >= 0 && value <= 130) {
                    idade = value;
                }
            }
        }

        public bool EhMaiorDeIdade() {
            return idade >= 18;
        }
    }
}
