using System;
using System.Collections.Generic;


public class Produto<T>
{
    public T Nome { get; set; }

    public Produto(T nome)
    {
        Nome = nome;
    }
}


public class Container<T>
{
    public List<T> Itens { get; set; }

    public Container(List<T> itens)
    {
        Itens = itens;
    }
}


public class Andar<T>
{
    public List<Container<T>> Containers { get; set; }

    public Andar(List<Container<T>> containers)
    {
        Containers = containers;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        var geladeira = new List<Andar<Produto<string>>>
        {
            new Andar<Produto<string>>(new List<Container<Produto<string>>>
            {
                new Container<Produto<string>>(new List<Produto<string>>
                {
                    new Produto<string>("Manga"),
                    new Produto<string>("Goiaba"),
                    new Produto<string>("Laranja"),
                    new Produto<string>("Pera")
                }),
                new Container<Produto<string>>(new List<Produto<string>>
                {
                    new Produto<string>("Beterraba"),
                    new Produto<string>("Pepino"),
                    new Produto<string>("Rabanete"),
                    new Produto<string>("Alface")
                })
            }),
            new Andar<Produto<string>>(new List<Container<Produto<string>>>
            {
                new Container<Produto<string>>(new List<Produto<string>>
                {
                    new Produto<string>("Leite"),
                    new Produto<string>("Iogurte"),
                    new Produto<string>("Queijo"),
                    new Produto<string>("Requeijão")
                }),
                new Container<Produto<string>>(new List<Produto<string>>
                {
                    new Produto<string>("Manteiga"),
                    new Produto<string>("Creme de Leite"),
                    new Produto<string>("Iorgute Natural"),
                    new Produto<string>("Queijo Minas")
                })
            }),
            new Andar<Produto<string>>(new List<Container<Produto<string>>>
            {
                new Container<Produto<string>>(new List<Produto<string>>
                {
                    new Produto<string>("Presunto Seara"),
                    new Produto<string>(" Frango Caipira"),
                    new Produto<string>("Costela Suina"),
                    new Produto<string>("Costela Bovina")
                }),
                new Container<Produto<string>>(new List<Produto<string>>
                {
                    new Produto<string>("Frango"),
                    new Produto<string>("Carne Bovina"),
                    new Produto<string>("Ovo"),
                    new Produto<string>("Bacon")
                })
            })
        };

       
        for (int andarIndex = 0; andarIndex < geladeira.Count; andarIndex++)
        {
            var andar = geladeira[andarIndex];
            Console.WriteLine($"Andar {andarIndex + 1}:");
            for (int containerIndex = 0; containerIndex < andar.Containers.Count; containerIndex++)
            {
                var container = andar.Containers[containerIndex];
                Console.WriteLine($"  Container {containerIndex + 1}:");
                for (int itemIndex = 0; itemIndex < container.Itens.Count; itemIndex++)
                {
                    Console.WriteLine($"    Posição {itemIndex + 1}: {container.Itens[itemIndex].Nome}");
                }
            }
            Console.WriteLine();
        }
    }
}
