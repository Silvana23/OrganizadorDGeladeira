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
            Console.WriteLine($"Item {item} adicionado na posição {posicao + 1}.");
        }
        else
        {
            Console.WriteLine($"Posição {posicao + 1} já está ocupada.");
        }
    }

    public void RemoverItem(int posicao)
    {
        if (Itens[posicao] != null)
        {
            Console.WriteLine($"Item {Itens[posicao]} removido da posição {posicao + 1}.");
            Itens[posicao] = default;
        }
        else
        {
            Console.WriteLine($"Posição {posicao + 1} já está vazia.");
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
                    Console.WriteLine($"Item {item} adicionado na posição {i + 1}.");
                    return;
                }
            }
        }
        else
        {
            Console.WriteLine("O container está cheio, não é possível adicionar mais itens.");
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
            Console.WriteLine("O container já está vazio.");
        }
    }
}
