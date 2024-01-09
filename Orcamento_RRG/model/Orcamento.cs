using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento_RRG.model
{
    internal class Orcamento
    {
        public Orcamento()
        {

        }

        public Orcamento(string cliente, string data, string numero, double valor)
        {
            this.Cliente = cliente;
            this.Data = data;
            this.Numero = numero;
            this.Valor = valor;
        }

        public Orcamento(string cliente, string data, string numero, double valor, int id)
        {
            this.Cliente = cliente;
            this.Data = data;
            this.Numero = numero;
            this.Valor = valor;
            this.Id = id;
        }

        private String cliente;
        private String data;
        private String numero;
        private double valor;
        private int id;

        public string Cliente { get => cliente; set => cliente = value; }
        public string Data { get => data; set => data = value; }
        public string Numero { get => numero; set => numero = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Id { get => id; set => id = value; }
    }
}
