namespace B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ngp;
            int noG;
            int noP;
            int result = 0;
            do
            {
                string input = Console.ReadLine();
                ngp = Convert.ToInt32(input.Split(" ")[0]);
                noG = Convert.ToInt32(input.Split(" ")[1]);
            } while (ngp < 1 || ngp > 100 || noG < 1 || noG > 100);

            int[] gp = new int[ngp];

            for (int i = 0; i < noG; i++)
            {
                do
                {
                    noP = Convert.ToInt32(Console.ReadLine()) - 1;
                } while (noP > gp.Length || noP < 0);
                gp[noP] = 1;
                noP = 0;
            }

            for (int j = 0; j < (ngp - 1); j++)
            {
                if (gp[j] == 0 && (j+1) <= (ngp -1))
                {
                    if (gp[j+1] == 0)
                    {
                        gp[j + 1] = 1;
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
        
    }
}
