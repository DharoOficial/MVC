using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/produto.csv";
        private string PrepararLinha(Produto p)
        {
            return $"codigo = {p.Codigo} ; nome = {p.Nome} ; preco = {p.Preco}";
        }

        public void Cadastrar(Produto prod)
        {
            var linha = new string[] { PrepararLinha(prod) };
            File.AppendAllLines(PATH, linha);
        }

        public Produto (int _codigo, string _nome, float _preco)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

        public Produto()
        {
            string pasta = PATH.Split('/')[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

         public List<Produto> Ler()
        {         
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach(string linha in linhas)
            {
                
                string[] dado = linha.Split(";");

                Produto p   = new Produto();
                p.Codigo    = Int32.Parse( Separar(dado[0]) );
                p.Nome      = Separar(dado[1]);
                p.Preco     = float.Parse( Separar(dado[2]) );

                produtos.Add(p);
            }

            produtos = produtos.OrderBy(y => y.Nome).ToList();
            return produtos; 
        }
         private string Separar(string _coluna)
        {
            return _coluna.Split("=")[1];
        }
    }
}