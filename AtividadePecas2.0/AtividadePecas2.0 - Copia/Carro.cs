using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePecas2._0
{

    class Carro
    {
        //Criação das "Variaveis" presentes na lista Carro e puxa a lista Pecas
        public string marca, nome;
        public int ano;
        public List<Pecas> pecas;

        //Cria e determina a lista Carro e referencia a lista Pecas
        public Carro(string marca, string nome,
            int ano)
        {
            this.marca = marca;
            this.nome = nome;
            this.ano = ano;
            this.pecas = new List<Pecas>();
        }
    }
}
