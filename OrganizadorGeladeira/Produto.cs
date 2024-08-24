using System;

public class Produto<T>
{
    public int Id { get; set; }
    public T Nome { get; set; }

    public Produto(T nome, int id)
    {
        Nome = nome;
        Id = id;
    }

    public override string ToString()
    {
        return Nome.ToString();
    }
}
