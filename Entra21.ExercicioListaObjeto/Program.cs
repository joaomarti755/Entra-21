using Entra21.ExercicioListaObjeto;

Console.WriteLine(@"-----------MENU--------------
1 - Exercicio triangulo
2 - Exercicio Aluno");

var opcaoDesejado = 0;
var opcaoValida = false;

while(opcaoValida == false)
{
    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejado = Convert.ToInt32(Console.ReadLine());

        if(opcaoDesejado <= 0)
        {
            Console.WriteLine("Opção invalida");
        }
        else
        {
            opcaoValida = true;
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine("Opção invalida");
    }
}
opcaoValida = false;

if(opcaoDesejado == 1)
{
    var exercicio01 = new TrianguloControlador();
    exercicio01.GerenciarMenu();
}