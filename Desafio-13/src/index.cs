using System;

class Program
{
    // Classe para representar o resultado
    public class Resultado
    {
        public int SaldoVitorias { get; set; }
        public string Nivel { get; set; }
    }

    // Função que calcula o saldo de vitórias e determina o nível
    static Resultado CalcularNivel(int vitorias, int derrotas)
    {
        // Calcula o saldo de rankeadas
        int saldoVitorias = vitorias - derrotas;

        // Determina o nível com base nas vitórias
        string nivel;

        if (vitorias < 10)
        {
            nivel = "Ferro";
        }
        else if (vitorias >= 10 && vitorias <= 20)
        {
            nivel = "Bronze";
        }
        else if (vitorias >= 21 && vitorias <= 50)
        {
            nivel = "Prata";
        }
        else if (vitorias >= 51 && vitorias <= 80)
        {
            nivel = "Ouro";
        }
        else if (vitorias >= 81 && vitorias <= 90)
        {
            nivel = "Diamante";
        }
        else if (vitorias >= 91 && vitorias <= 100)
        {
            nivel = "Lendário";
        }
        else if (vitorias >= 101)
        {
            nivel = "Imortal";
        }
        else
        {
            nivel = "Indefinido"; // Caso padrão
        }

        // Retorna um objeto com o saldo e o nível
        return new Resultado { SaldoVitorias = saldoVitorias, Nivel = nivel };
    }

    static void Main()
    {
        // Exemplo de uso
        Resultado resultado = CalcularNivel(75, 20);
        Console.WriteLine($"O Herói tem de saldo de {resultado.SaldoVitorias} está no nível de {resultado.Nivel}");

        // Testando com outros valores
        Resultado resultado2 = CalcularNivel(15, 5);
        Console.WriteLine($"O Herói tem de saldo de {resultado2.SaldoVitorias} está no nível de {resultado2.Nivel}");

        Resultado resultado3 = CalcularNivel(7, 3);
        Console.WriteLine($"O Herói tem de saldo de {resultado3.SaldoVitorias} está no nível de {resultado3.Nivel}");
    }
}