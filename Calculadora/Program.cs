// Calculadora 
int x = -1;
while (x != 0) { 

Console.WriteLine("Qual operação deseja fazer?");
Console.WriteLine("Digite 1 - Para realizar a soma");
Console.WriteLine("Digite 2 - Para reaizar uma subtração");
Console.WriteLine("Digite 3 - Para realizar uma multiplicação");
Console.WriteLine("Digite 4 - Para realizar uma divisão");
Console.WriteLine("Digite 5 - Para realizar uma potenciação");
Console.WriteLine("Digite 6 - Para realizar uma radiciação");
Console.WriteLine("Digite 0 - Para sair do Programa.");
    x= int.Parse(Console.ReadLine());

    if (x == 1)
    {
        Console.WriteLine("Digite o valor: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("O resultado dessa operação é " + (a + b));
    }
    else if (x == 2)
    {
        Console.WriteLine("Digite o valor: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("O resultado dessa operação é " + (a - b));
    }
    else if (x == 3)
    {
        Console.WriteLine("Digite o valor: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("O resultado dessa operação é " + a * b);
    }
    else if (x == 4)
    {
        Console.WriteLine("Digite o valor: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int b = int.Parse(Console.ReadLine());
        while (b == 0)
        {
            Console.WriteLine("O valor é invalido, digite um novo valor !");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado dessa operação é " + a / b);
        }
        if (a % b != 0)
        {
            Console.WriteLine("Essa divisão possui resto:" + a % b);
        }
    }
    else if (x == 5)
    {
        Console.WriteLine("Digite o valor: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int b = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Valor inválido, digite outro valor: ");
            a= int.Parse(Console.ReadLine());
        }
        Console.WriteLine("O resultado dessa operação é " + Math.Pow(a,b));
    }
    else if(x == 6)
    {
        Console.WriteLine("Digite o valor: ");
        int a = int.Parse(Console.ReadLine());
        while (a > 0)
        {
            Console.WriteLine("Valor Invalido, digite outro valor: ");
        }
        Console.WriteLine("O resultado dessa operação é " + Math.Sqrt(a));
    }
    else
    {
        Console.WriteLine("Finalizando Operação...");
    }


}



