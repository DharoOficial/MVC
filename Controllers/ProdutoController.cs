using System.Collections.Generic;
using MVC.Models;
using MVC.View;
using System;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        Produto ProdutoModel = new Produto();
        ProdutoView ProdutoView = new ProdutoView();
    

   
    public void Buscar(string termo)
    {
        List<Produto> lista = ProdutoModel.Ler().FindAll(x => x.Preco == float.Parse(termo));
        ProdutoView.MostrarNoConsole(lista);
    }
    public void Listar()
    {
        List<Produto> lista = ProdutoModel.Ler();
        ProdutoView.MostrarNoConsole(lista);
    }


    }
}