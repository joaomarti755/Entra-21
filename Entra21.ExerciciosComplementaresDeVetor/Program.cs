using Entra21.ExerciciosComplementaresDeVetor;

Console.WriteLine(@"-------------MENU------------------
1-Exercicio01");

Console.Write("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if(opcaoDesejada == 1)
{
    var exercicio01 = new Exercicio01();
    exercicio01.Executar();
}