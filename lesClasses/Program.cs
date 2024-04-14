namespace lesClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character joueur1 = new Character("toto", 100, 50, 70);
            Character joueur2 = new Character("titi", 200, 300, 60);

            while (joueur1.IsAlive() && joueur2.IsAlive())
            {
                joueur1.Attack(joueur2);

                if (joueur2.IsAlive())
                {
                    joueur2.Attack(joueur1);
                }
            }
            if(joueur1.IsAlive())
            {
                Console.WriteLine($" {joueur1.Nom} a gagné ");
            }
            else
            {
                Console.WriteLine($" {joueur2.Nom} a gagne ");
            }
        }
    }

           

}

