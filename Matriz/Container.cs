using System;
using System.Collections.Generic;

public class Container<T>
{
    public List<T> Itens { get; set; }

    public Container(int capacidade)
    {
        Itens = new List<T>(new T[capacidade]);
    }

    public void AdicionarItem(int posicao, T item)
    {
        if (Itens[posicao] == null)
        {
            Itens[posicao] = item;
            Console.WriteLine($"Item {item} adicionado na posi��o {posicao + 1}.");
        }
        else
        {
            Console.WriteLine($"Posi��o {posicao + 1} j� est� ocupada.");
        }
    }

    public void RemoverItem(int posicao)
    {
        if (Itens[posicao] != null)
        {
            Console.WriteLine($"Item {Itens[posicao]} removido da posi��o {posicao + 1}.");
            Itens[posicao] = default;
        }
        else
        {
            Console.WriteLine($"Posi��o {posicao + 1} j� est� vazia.");
        }
    }

    public void AdicionarItens(T item)
    {
        if (Itens.Contains(default(T)))
        {
            for (int i = 0; i < Itens.Count; i++)
            {
                if (Itens[i] == null)
                {
                    Itens[i] = item;
                    Console.WriteLine($"Item {item} adicionado na posi��o {i + 1}.");
                    return;
                }
            }
        }
        else
        {
            Console.WriteLine("O container est� cheio, n�o � poss�vel adicionar mais itens.");
        }
    }

    public void RemoverTodosItens()
    {
        if (Itens.Exists(x => x != null))
        {
            Itens = new List<T>(new T[Itens.Count]);
            Console.WriteLine("Todos os itens foram removidos do container.");
        }
        else
        {
            Console.WriteLine("O container j� est� vazio.");
        }
    }
}
