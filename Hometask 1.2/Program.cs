namespace Hometask_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Budget of Azerbaijan Republic
            double budget = 20000000000;
            int defencePercentOfBudget = 20;
            int highTechnologyPercentOfBudget = 10;

            Console.WriteLine("Büdcə :");
            Console.WriteLine(budget);

            Console.WriteLine("Müdafiə Nazirliyinə :");
  
            double defenceBudget = budget * defencePercentOfBudget / 100;

            Console.WriteLine(defenceBudget);


            Console.WriteLine("Yüksək Texnologiyalar Nazirliyinə :");
            double highTechnologyfBudget = budget * highTechnologyPercentOfBudget / 100;
            Console.WriteLine(highTechnologyfBudget);


            Console.WriteLine("Yerdə' qalan büdcə :");
            double restBudget = budget - defenceBudget - highTechnologyfBudget;

            Console.WriteLine(restBudget );

        }
    }
}