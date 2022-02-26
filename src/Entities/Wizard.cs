namespace POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Attack com a sua magia";
        }
        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return this.Name + " Attack com a sua magia Forte";
            }
            else
            {
                return this.Name + " Attack com a sua magia Fraca";
            }
        }
    }
}