using Entra21.ExercicioListas;

Console.WriteLine(@"----------------MENU----------------
1-Exercicio01
2-Exercicio02
3-Exercicio03");

var opcaoValida = false;
var opçaoDesejada = 0;
while(opcaoValida == false)
{
    try
    {
        Console.Write("Digite a opção desejada: ");
        opçaoDesejada = Convert.ToInt32(Console.ReadLine());
        if((opçaoDesejada <= 0) || (opçaoDesejada > 3))
        {
            Console.WriteLine("Opção invalida");
        }
        else
        {
            opcaoValida = true;
        }
    }catch(Exception ex)
    {
        Console.WriteLine("Opção invalida");
    }
}
opcaoValida = false;

if(opçaoDesejada == 1)
{
    var exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if(opçaoDesejada == 2)
{
    var exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if(opçaoDesejada == 3)
{
    var exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
