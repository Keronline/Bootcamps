namespace GFT.src
{
    public abstract class Persona
    {
        
        public string Name;
        public int Level;
        public string HeroType;
        public string Arm; 
        public int Power;
        public Persona(string Name, int Level, string HeroType, string Arm, int Power)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Arm = Arm;
            this.Power = Power;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}. Life: {this.Level}. Type: {this.HeroType}";
        }
   
        public abstract int Attack(int Bonus);

    }
}