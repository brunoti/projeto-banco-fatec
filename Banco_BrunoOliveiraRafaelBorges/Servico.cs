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
    public abstract class Servico {

        private Cliente cliente;
        private DateTime data;

        public Servico(Cliente cliente, DateTime data) {
            this.cliente = cliente;
            this.data = data;
        }

        public Cliente Titular {
            get {
                return cliente;
            }
        }

        public DateTime DataDeContratacao {
            get {
                return data;
            }
        }

        public virtual float TaxaAdm {
            get {
                return 10.0f;
            }
        }
    }
}
