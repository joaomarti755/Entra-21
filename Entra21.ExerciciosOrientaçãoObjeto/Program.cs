using Entra21.ExerciciosOrientacaoObjeto.Exercicio01;

Console.WriteLine(@"------------MENU-----------
1-Exercicio01");
var opcaoDesejada = 0;
var opcaoValida = false;

while(opcaoValida == false)
{
    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());
        if(opcaoDesejada <= 0)
        {
            Console.WriteLine("Número invalido");
        }
        else
        {
            opcaoValida = true;
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine("Número Invalido");
    }
}
opcaoValida = false;

if(opcaoDesejada == 1)
{
    var exercicio01 = new ExemploLivro();
    exercicio01.Executar();
}