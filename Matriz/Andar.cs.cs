using System.Collections.Generic;

public class Andar<T>
{
    public List<Container<T>> Containers { get; set; }

    public Andar(List<Container<T>> containers)
    {
        Containers = containers;
    }
}
