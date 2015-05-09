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
    public class Seguro : Servico {
        private Automovel automovel;

        public Seguro(Cliente cliente, DateTime data, Automovel automovel)
            : base(cliente, data) {
            this.automovel = automovel;
        }

        public float Franquia {
            get {
                float taxa;
                if (automovel.Ano == DataDeContratacao.Year) {
                    taxa = 0.4f;
                } else {
                    taxa = 0.5f;
                }
                return ValorSeguro * taxa;
            }
        }

        public float ValorSeguro {
            get {
                if (automovel.Ano < 2004) {
                    return automovel.Preco * 0.9f;
                } else if (automovel.Ano < 2010) {
                    return automovel.Preco;
                }

                return automovel.Preco * 1.1f;
            }
        }

        public override float TaxaAdm {
            get {
                return Franquia * 0.01f;
            }
        }
    }
}
