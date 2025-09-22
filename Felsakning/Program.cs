namespace Felsakning
{
    //Nikki Norberg SUT25
    internal class Program
    {
        static void Main(string[] args)
        {
            // Case 1
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre"); //Denna saknade en ;
            }
            else if (number < 3) //Denna ska ha ett mellanslag mellan else och if
            {
                Console.WriteLine("Talet är mindre än tre");
            }
            //--

            // Case 2
            for (int i = 1; i < (100 + 1); i++) // i hinner aldrig komma upp till 100 då den bara kör tal som är mindre än 100, därför sätter jag den till 100 + 1
            {
                Console.WriteLine(i);
            }
            //--

            // Case 3
            for (int i = 1; i <= 5; i++) // i måste ändras på något vis så jag la till ++
            {
                for (int j = 1; j <= i; j++) //samma här med j
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            //--

            // Case 4
            int x = 1; //Jag fick ändra denna från i till x så att de andra casen inte blir sura
            while (x <= 5)
            {
                for (int j = 1; j <= x; j++)
                {
                    Console.Write("k"); //Man speceficerar inte vad som ska skrivas ut i konsollen, denna måste ta in ett värde, olikt WriteLine(). Jag la till ett k
                }

                Console.WriteLine(); //Enter
                x++;
            }
            //--

            //Case 5
            int y = 1; //ändrade denna från i till y

            switch (y)
            {
                case 1: //case 1 saknade en break;, så jag la till en
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            //--

            // Case 6
            int z = 10; //Ändrade från i till z

            if (z == 5) // 1 = 5 försöker ändra på z:s värde, det skall vara == för att kolla om z verkligen är lika med 5
            {
                Console.WriteLine("z är 5"); //Kommer inte köras efter som att z inte är lika med 5
            }
        }
    }
}
