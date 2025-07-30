using System;
using System.Collections.Generic;

class Heroi
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Tipo { get; set; }

    public Heroi(string nome, int idade, string tipo)
    {
        Nome = nome;
        Idade = idade;
        Tipo = tipo.ToLower();
    }

    public void Atacar()
    {
        string ataque;

        switch (Tipo)
        {
            case "mago":
                ataque = "usou magia";
                break;
            case "guerreiro":
                ataque = "usou espada";
                break;
            case "monge":
                ataque = "usou artes marciais";
                break;
            case "ninja":
                ataque = "usou shuriken";
                break;
            default:
                ataque = "atacou de forma desconhecida";
                break;
        }

        Console.WriteLine($"O {Tipo} atacou usando {ataque}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Lista de heróis
        List<Heroi> herois = new List<Heroi>
        {
            new Heroi("Merlin", 150, "mago"),
            new Heroi("Arthas", 35, "guerreiro"),
            new Heroi("Lee", 28, "monge"),
            new Heroi("Hanzo", 30, "ninja")
        };

        // Executando o ataque de cada herói
        foreach (Heroi heroi in herois)
        {
            heroi.Atacar();
        }

        // Pausa para ver a saída no console
        Console.ReadLine();
    }
}
