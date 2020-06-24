using System;
using System.Collections.Generic;

namespace Aula24ObjetosComoArgumento
{
    public class Carrinho
    {
        
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto prod_){

            carrinho.Add(prod_);
        
        }

        public void Remover(Produto p_){

            carrinho.Remove(p_);

        }

        public void Ler(){

            foreach(Produto item in carrinho){

                System.Console.WriteLine($"{item.Codigo} - {item.Nome} - R$ {item.Preco}");

            }

        }

        public void MostrarTotal(){

            foreach(Produto item in carrinho){

                ValorTotal += item.Preco;

            }
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Valor total da compra: R$ {ValorTotal}");
            Console.ResetColor();
        
        }

        public void Alterar(int _cod, Produto _prodAlt){

            carrinho.Find(z => z.Codigo == _cod).Nome = _prodAlt.Nome;
            carrinho.Find(z => z.Codigo == _cod).Preco = _prodAlt.Preco;

        }

    }
}