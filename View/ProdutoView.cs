using System.Collections.Generic;
using MVC.Models;
using System;

namespace MVC.View
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach (Produto item in lista )
            {
                Console.WriteLine($"R${item.Preco} - {item.Nome}");
            }
        }
    }
}