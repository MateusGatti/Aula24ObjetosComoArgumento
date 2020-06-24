using System;

namespace Aula24ObjetosComoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto(1, "Rocket League", 36.90f);
            Produto p2 = new Produto(2, "Life is Strange", 48.90f);
            Produto p3 = new Produto(3, "Stardew Valley", 19.90f);
            Produto p4 = new Produto(4, "Dreaming Sarah", 9.90f);

            carrinho.Adicionar(p1);
            carrinho.Adicionar(p2);
            carrinho.Adicionar(p3);
            carrinho.Adicionar(p4);

            carrinho.Remover(p1);

            Produto prodAlt = new Produto(3, "Left 4 Dead 2", 26.90f);
            carrinho.Alterar(3, prodAlt);

            carrinho.Ler();
            carrinho.MostrarTotal();

        }
    }
}
