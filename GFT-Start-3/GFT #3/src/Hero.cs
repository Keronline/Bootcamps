namespace GFT.src
{
    public abstract class Hero
    {
        
        public string Name;
        public int Level;
        public string HeroType;
        public string Arm; 
        public int Power;
        public Hero(string Name, int Level, string HeroType, string Arm, int Power)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Arm = Arm;
            this.Power = Power;

        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        
        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua " + Arm;
        }
        public string Attack(int Bonus)
        {
            if( Bonus > 6) return this.Name + " Lançou Magia super efetiva com o seu cajado resultando em um ataque de " + Bonus;    
            return this.Name + " Lançou Magia fraca resultando em um ataque de " + Bonus;
        }

    }
}