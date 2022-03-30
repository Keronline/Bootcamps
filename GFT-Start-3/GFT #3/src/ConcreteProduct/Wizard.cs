namespace GFT.src;

public class Wizard : Persona
{
    public Wizard(string Name, int Level, string HeroType, string Arm, int Power) : base(Name, Level, HeroType, Arm, Power)
    {

    }

    public override int Attack(int Bonus)      
    {
        if( Bonus > 3) {
            Console.WriteLine(this.Name + " Lan�ou Magia super potente com "+ this.Arm+ " e resultou em um ataque de " + this.Power+Bonus + " em seu oponente.");    
            return this.Power + Bonus;
        }
        Console.WriteLine(this.Name + " Lan�ou um ataque fraco e resultou em um dano de " + this.Power + " em seu oponente.");
        return this.Power;
    }

}
