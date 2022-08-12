
// = serve para atribuir valor a uma variavel
// == serve para comparar valor de uma variavel com outra
// != serve para comparar valor de uma variavel com outra
// >  serve para comparar valor de uma variavel com outra
// <  serve para comparar valor de uma variavel com outra
// >= serve para comparar valor de uma variavel com outra
// <= serve para comparar valor de uma variavel com outra
// && serve para comparar valor de uma variavel com outra
// || serve para comparar valor de uma variavel com outra
// ! serve para inverter o valor de uma variavel
// ^ serve para comparar valor de uma variavel com outra
// & serve para comparar valor de uma variavel com outra
// | serve para comparar valor de uma variavel com outra
// + serve para somar valor de uma variavel com outra
// - serve para subtrair valor de uma variavel com outra
// * serve para multiplicar valor de uma variavel com outra
// / serve para dividir valor de uma variavel com outra
// % serve para obter o resto de uma divisao
// ++ serve para incrementar valor de uma variavel
// -- serve para decrementar valor de uma variavel
// += serve para somar valor de uma variavel com outra e atribuir a variavel
// -= serve para subtrair valor de uma variavel com outra e atribuir a variavel
// *= serve para multiplicar valor de uma variavel com outra e atribuir a variavel
// /= serve para dividir valor de uma variavel com outra e atribuir a variavel
// %= serve para obter o resto de uma divisao e atribuir a variavel
// ? serve para fazer uma condicao
// ? faz uma condicao e executa uma ação
// : serve para fazer uma condicao
// $ serve para fazer uma condicao
// @ serve para fazer uma condicao
// if é uma condicao
// for é um laço de repeticao
//. faz uma referencia a uma variavel
//is serve para comparar valor de uma variavel com outra

// Console.Write("Digite o primeiro nome: ");
// string name = Console.ReadLine();
// Console.WriteLine($"Ola {name}");
// Console.Write("Digite o ano do seu nascimento: ");
// int year = int.Parse(Console.ReadLine());
// Console.WriteLine($"Voce nasceu em {year}");
// int age = 2022 - year;
// Console.WriteLine($"Voce tem {age} anos");

// if (age > 18)
// {
//     Console.WriteLine("Voce e maior de idade");
// }
// else
// {
//     Console.WriteLine("Voce e menor de idade");
// }

class Program
{
    static void Main()
    {
        // string[] names = { "Fredi", "Joao", "Maria" };

        // if (string.Equals(names[0], "redi",StringComparison.OrdinalIgnoreCase))
        // {
        //     Console.WriteLine("Igual");
        // }

        // foreach(string name in names)
        // {
        //     Console.WriteLine(name);
        // }


        // int? i = 10;
        // int? i2 = i;
        // i2 = 20;

        // i = null;

        // if (i is null){
        //     Console.WriteLine("Nulo");
            
        // }

        // Test t1 = new Test();
        // t1.x = 12;

        // Test t2 = t1;
        // t2 = new Test();
        // t2.x = 20;

        // Console.WriteLine(t1.x);


        string s = null;

        try
        {
            Console.WriteLine(s.Length);
        }
        catch (System.NullReferenceException)
        {
            Console.WriteLine("Erro de referencia nula");
        }
        finally
        {
            Console.WriteLine("Final");
        }

        



    }

}

class Test
{
    public int x;
}

