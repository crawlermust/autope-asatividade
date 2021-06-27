using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePecas2._0
{
    class Pecas
    {
        //Criação das "Variaveis" presentes na lista Pecas
        public string marca, nome, modelo;
        public decimal valor;

        //Cria e determina a lista
        public Pecas(string marca, string nome,
            string modelo, decimal valor)
        {
            this.marca = marca;
            this.nome = nome;
            this.modelo = modelo;
            this.valor = valor;
        }
    }
}
