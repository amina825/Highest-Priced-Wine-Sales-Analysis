internal class Program
{
    static void Main(string[] args)
    {
        int numberofmovies;
        //coding test tak a amina arooj uxm59h
        do {
            Console.WriteLine("enter the number of movies");
            numberofmovies = Convert.ToInt32(Console.ReadLine());
            if (numberofmovies <= 1 || numberofmovies >= 50)
            {
                Console.WriteLine("enter number of movies is incorrect");
            }
        } while (numberofmovies <= 1 || numberofmovies >= 50);
        for (int i = 0; i < numberofmovies;)
        {
            int[] movieduration = new int[numberofmovies];
            Console.WriteLine($"enter the name of {i + 1} movie and duratiom");
            String input = Console.ReadLine();
            movieduration[1] = Convert.ToInt32(input.Split(" "));
            string moviename = input.Split(" ")[0];
            if (movieduration[i] >= 1 && movieduration[i] <= 300 && moviename.Length >= 1 && moviename.Length <= 50)
            {
                i++;
            }
            else
            {
                Console.WriteLine("wrong input ");
            }
            int maxduration = movieduration[1];
            for (int k = 0; k < movieduration.Length; k++)
            {

                if (movieduration[i] > maxduration)
                {
                    maxduration = movieduration[i];
                }
                Console.WriteLine($"the movies of maximum duration are {maxduration}");
            }



        }
       
    }
}