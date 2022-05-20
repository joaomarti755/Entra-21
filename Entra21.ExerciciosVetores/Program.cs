
using Entra21.ExerciciosVetores;

Console.WriteLine(@"----------------MENU---------------------
1-Exercicio01
2-Exercicio02
3-Exercicio03
4-Exercicio04
5-Exercicio05");

Console.Write("Digita a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if(opcaoDesejada == 1)
{
    var exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if(opcaoDesejada == 2)
{
    var exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if(opcaoDesejada == 3)
{
    var exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if(opcaoDesejada == 4)
{
    var exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
else if(opcaoDesejada == 5)
{
    var exercicio05 = new Exercicio05();
    exercicio05.Executar();
}