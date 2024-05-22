using System;

class Program
{
    static void Main(string[] args)
    {
        // bool possuiOvos = true;
        // string itensComprados = "";

        // if(possuiOvos)
        // {
        //     itensComprados = "Leite";
        //     Console.WriteLine($"Item comprado : {itensComprados}.\nVamos fazer um bolo !");
        // }
        // else
        // {
        //     Console.WriteLine($"Item comprado : Lasanha congelada.");
        // }

        Console.WriteLine("Olá amigo, vamos sair para comer fora ?\nQual o nível da sua fome ?");
        int nivelFome = Convert.ToInt32(Console.ReadLine()!);    /// Colocar 8000 .

        if(nivelFome == 1){
            Console.WriteLine("Vamos comer uma torrada com suco !");

        }
        else if( nivelFome == 2){
            Console.WriteLine("Vamos comer Arroz com feijão e batatinhas .");
        }
        else{
            Console.WriteLine("O nível da sua fome é mais de 8000 mil !!!\nVamos para a pizzaria !");
        }

        //     Console.WriteLine("Olá cliente !\nEscolha sua fruta :\nLaranja.\nBanana.\nLimão.\nMorango.\nAbacaxi.\nQuero algo com gás.\n");
        //     string fruta = Convert.ToString(Console.ReadLine()!);

        //     switch (fruta)
        //     {
        //         case "Laranja":
        //         case "Limão":
        //         case "Abacaxi":
        //             Console.WriteLine("Certo, vamos fazer um suco delicioso para você !");
        //             break;
        //         case "Banana":
        //         case "Morango":
        //             Console.WriteLine("Certo, vamos fazer uma vitamina deliciosa para você !");
        //             break;
        //         default:
        //             Console.WriteLine("Vamos tomar um refrigerante .");
        //             break;
        //     }
        // }
    }
}