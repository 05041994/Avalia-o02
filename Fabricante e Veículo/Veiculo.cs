using System;
using System.Collections.Generic;
using System.Text;

namespace Fabricante_e_Veículo
{
    class Fabricante
    {
        private string nome, sigla;
        private int i = 0;
        private readonly Veiculo[] veiculos = new Veiculo[1];

        public Fabricante(string n, string s)
        {
            nome = n;
            sigla = s;
        }

        public void Inserir(Veiculo v)
        {
            if (i == veiculos.Length)
            {
                Array.Resize(ref veiculos, veiculos.Length * 2);
            }

            veiculos[i] = v;
            i++;
        }
        public Veiculo[] Listar()
        {
            Veiculo[] vetor = new Veiculo[i];
            Array.Copy(veiculos, vetor, i);
            return vetor;
        }
        public double Maiorpreco()
        {
            Veiculo aux = veiculos[0];
            for (int k = 1; k < i; k++)
            {
                //if (veiculos[k].Getpreço() > aux.Getpreço())
                //{
                //    aux = veiculos[k];
                //}

            }

        }
        public override string ToString()
        {
            return $"Nome da fabrica {nome} e a sigla {sigla}";
        }
    }
    class Veiculo
    {
        private string nome, modelo;
        private double preco;

        public Veiculo(string n, string m, double p)
        {
            nome = n;
            modelo = m;
            if (p > 0)
            {
                preco = p;
            }
        }
        public double Getpreço()
        {
            return preco;
        }

        public override string ToString()
        {
            return $"{nome} Veículo do modelo {modelo} Valor: {preco:0.00}";
        }
    }
}
