using System;
using System.Collections.Generic;

public class Andar<T>
{
    public List<Container<T>> Containers { get; set; }

    public Andar(List<Container<T>> containers)
    {
        Containers = containers;
    }

    public void ExibirAndar(int andarIndex)
    {
        Console.WriteLine($"Andar {andarIndex + 1}:");
        for (int i = 0; i < Containers.Count; i++)
        {
            Console.WriteLine($"  Container {i + 1}:");
            Containers[i].ExibirItens();
        }
        Console.WriteLine();
    }
}
