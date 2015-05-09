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
    public class EmprestimoPessoal : Servico {
        private float valor;
        private int parcelas;

        public EmprestimoPessoal(Cliente cliente, DateTime data, float valor, int parcela)
            : base(cliente, data) {
            this.QuantidadeParcelas = parcela;
            this.ValorTotalFinanciado = valor;
        }

        public int QuantidadeParcelas {
            get {
                return parcelas;
            }
            set {
                if (value <= 0) {
                    throw new ArgumentException();
                } else {
                    parcelas = value;
                }
            }
        }


        public float ValorParcela {
            get {
                return (float)((valor * Math.Pow(1 + (TaxaJuros / 100), parcelas)) / parcelas);
            }
        }

        public float TaxaJuros {
            get {
                if (valor <= 5000) {
                    return 1.5f;
                } else if (valor <= 50000) {
                    return 1f;
                } else {
                    return 0.75f;
                }
            }
        }
        public float ValorTotalFinanciado {
            get {
                return valor;
            }
            set {
                if (value < 0) {
                    throw new ArgumentException();
                } else {
                    valor = value;
                }
            }
        }
    }
}
