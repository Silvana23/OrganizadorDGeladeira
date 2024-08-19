using System;

public class Produto<T>
{
    public T Nome { get; set; }

    public Produto(T nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return Nome.ToString();
    }
}
