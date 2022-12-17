using System;
using System.Collections.Generic;
using System.Text;

namespace Fabricante_e_Veículo
{
    class Fabricante
    {
        private string nome, sigla;
        private int i = 0;
        private Veiculo[] veiculos = new Veiculo[1];

        public void SetNomeFabricante(string n)
        {
            if (n != "") nome = n;
        }
        public string GetNomeFabricante()
        {
            return nome;
        }

        public void SetSigla(string s)
        {
            if (s != "") sigla = s;
        }
        public string GetSigla()
        {
            return sigla;
        }


        public Fabricante(string n, string s)
        {
            nome = n;
            sigla = s;
        }

        public Fabricante()
        {
            //Contrudor
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
            int k = 1;
            while (k < i)
            {
                if (veiculos[k].Getpreço() > aux.Getpreço())
                {
                    aux = veiculos[k];
                }
                k++;
            }
            return aux.Getpreço();
        }
        public override string ToString()
        {
            return $"Nome da fabrica {nome} e a sigla {sigla}";
        }
    }
}
