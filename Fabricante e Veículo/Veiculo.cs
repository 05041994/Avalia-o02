using System;
using System.Collections.Generic;
using System.Text;

namespace Fabricante_e_Veículo
{
    class Veiculo
    {
        private string nome, modelo;
        private double preco;

        public void SetNome(string n)
        {
            if (n != "") nome = n;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetModelo(string m)
        {
            if (m != "") modelo = m;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public void SetPreco(double p)
        {
            if (p >= 0) preco = p;
        }
        public double Getpreço()
        {
            return preco;
        }

        public Veiculo(string n, string m, double p)
        {
            nome = n;
            modelo = m;
            preco = p;
        }

        public Veiculo()
        {
            //Contrudor
        }

        public override string ToString()
        {
            return $"{nome} Veículo do modelo {modelo} Valor: {preco:0.00}";
        }
    }
}
