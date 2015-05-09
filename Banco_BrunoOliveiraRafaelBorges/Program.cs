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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_BrunoOliveiraRafaelBorges {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
