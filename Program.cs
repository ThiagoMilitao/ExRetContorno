Console.WriteLine("Digite a altura do retângulo (entre 1 e 10):");
int altura = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a largura do retângulo (entre 1 e 10):");
int largura = int.Parse(Console.ReadLine());

if (altura < 1 || altura > 10 || largura < 1 || largura > 10)
{
    Console.WriteLine("Altura e largura devem estar entre 1 e 10.");
    return;
}

for (int i = 0; i < largura; i++)
{
    Console.Write("*");
}
Console.WriteLine();

for (int i = 0; i < altura - 2; i++)
{
    Console.Write("*");
    for (int j = 0; j < largura - 2; j++)
    {
        Console.Write(" ");
    }
    if (largura > 1)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i = 0; i < largura; i++)
{
    Console.Write("*");

    }
