
using Entra21.ExerciciosWhile;

Console.WriteLine(@"----------MENU-DE-EXERCICÍOS-WHILE------------
1-Exercicio01
2-Exercicio02
3-Exercicio03
4-Exercicio04
5-Exercicio05
6-Exercicio06
7-Exercicio07
8-Exercicio08
11-Exercicio11
12-Exercicio12
13-Exercicio13");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if (opcaoDesejada == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if (opcaoDesejada == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (opcaoDesejada == 6)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
else if (opcaoDesejada == 7)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();
}
else if (opcaoDesejada == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if(opcaoDesejada == 11)
{
    Exercicio11 exercicio11 = new Exercicio11();
    exercicio11.Executar();
}
else if(opcaoDesejada == 12)
{
    Exercicio12 exercicio12 = new Exercicio12();
    exercicio12.Executar();
}
else if(opcaoDesejada == 13)
{
    Exercicio13 exercicio13 = new Exercicio13();
    exercicio13.Executar();
}