using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento_RRG.model
{
    internal class Produto
    {
        public Produto(string nome, int numero, double valorVenda, double valorCompra, string codigo)
        {
            this.nome = nome;
            this.numero = numero;
            this.valorVenda = valorVenda;
            this.valorCompra = valorCompra;
            this.codigo = codigo;
        }

        public Produto(string nome, double valorVenda, double valorCompra, string codigo)
        {
            this.Nome = nome;
            this.ValorVenda = valorVenda;
            this.ValorCompra = valorCompra;
            this.Codigo = codigo;
        }

        private String nome;
        private int numero;
        private double valorVenda;
        private double valorCompra;
        private String codigo;

        public string Nome { get => nome; set => nome = value; }
        public int Numero { get => numero; set => numero = value; }
        public double ValorVenda { get => valorVenda; set => valorVenda = value; }
        public double ValorCompra { get => valorCompra; set => valorCompra = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
