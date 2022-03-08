using System;
using GFT.src;

namespace GFT
{
    class Program
    {
        static void Main(string[] args)
        {            
            string opicao = "0"; 
            do
            {                 
                Console.WriteLine("Qual jogador você escolhe? \n");

                System.Console.WriteLine("a - jogar com Knight");
                System.Console.WriteLine("b - jogar com White Wizard");
                System.Console.WriteLine("c - jogar com Ninja");
                System.Console.WriteLine("x - encerrar jogo\n");

                opicao = Console.ReadLine();
                int dano = 0;

                Knight hero = new Knight("Arus", 23, "Knight", "Espada", 13);
                Wizard wizard = new Wizard("Jennica", 23, "White Wizard", "Magia", 16);
                Ninja ninja = new Ninja("Jennica", 23, "White Wizard", "Magia", 15);
                
                switch(opicao)
                {
                    case "a":
                        Console.WriteLine(hero);
                        break;
                    case "b":                        
                        Console.WriteLine(wizard);
                        break;
                    case "c":                        
                        Console.WriteLine(ninja);
                        break;
                    default:
                        continue;
                }
                Knight oponnent = new Knight("Maleficus", 99, "Devil", "Mordida", 9);
                Console.WriteLine($"\nSeu primeiro oponente sera {oponnent}");

                System.Console.WriteLine($"O seu ataque foi de {hero.Power}");
                System.Console.WriteLine($"O ataque de {oponnent.Name} foi de {oponnent.Power}");
                dano = oponnent.Power - hero.Power;
                if (dano < 0)
                {
                    System.Console.WriteLine("Você vendeu a luta");
                }
                else
                {
                    System.Console.WriteLine("Você perdeu a luta");                
                }

            }while(opicao != "x");
        }
    }
}