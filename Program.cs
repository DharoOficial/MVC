using System;
using MVC.Controllers;
using MVC.Models;

namespace MVC
{
    class Program
    {
        Produto p1 = new Produto(1,"Metro",123.5f);
        Produto p2 = new Produto(2,"Withcer",312.7f);
        Produto p3 = new Produto(3,"Hyper_Scape",321.5f);

         static void Main(string[] args)
        {
                ProdutoController produtos = new ProdutoController();
                produtos.Buscar("123.5");
        }        
    }
}
