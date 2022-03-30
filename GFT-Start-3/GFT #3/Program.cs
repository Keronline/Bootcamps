using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using GFT.src;

namespace GFT
{
    class Program
    {
        static void Main(string[] args)
        {            
            string opicao = "0";
            string resultadoLuta;
            
            Random aleatorio = new Random();
            int bonusCharacter;

            int bonusOponnet;

            do
            {                 
                Console.WriteLine("Qual jogador você escolhe? \n");
                System.Console.WriteLine("a - jogar com Knight");
                System.Console.WriteLine("b - jogar com White Wizard");
                System.Console.WriteLine("c - jogar com Ninja");
                System.Console.WriteLine("x - encerrar jogo\n");

                opicao = Console.ReadLine();
                int dano = 0;

                Persona character = null; 
                
                switch(opicao)
                {
                    case "a":
                        character = new Knight("Arus", 25, "Knight", "Espada", 14);
                        break;
                    case "b":
                        character = new Wizard("Jennica", 25, "White Wizard", "Cajado", 16);
                        break;
                    case "c":
                        character = new Ninja("Steik", 25, "Ninja", "AK-47", 15);
                        break;
                    default:
                        continue;
                }
                bonusOponnet = aleatorio.Next(8);
                bonusCharacter = aleatorio.Next(15);
                System.Console.WriteLine("Personagem escolhido!");
                System.Console.WriteLine(character);
                Persona oponnent = new Knight("Maleficus", 99, "Devil", "Mordida", 9);
                dano = character.Attack(bonusCharacter) - oponnent.Attack(bonusOponnet);
                if (dano > 0)
                {
                    resultadoLuta = "\nVocê venceu a luta\n";
                }
                else
                {
                    resultadoLuta = "\nSeu oponente levou a melhor desta vez... Mas não desista!";                
                }
                System.Console.WriteLine(resultadoLuta);
                System.Console.WriteLine("Precione ENTER tecla para continuar");
                Console.ReadLine();

            } while(opicao != "x");
        }
    }
}