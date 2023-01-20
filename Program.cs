namespace deliverable2_ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the percentage grade you expect to get in the class ISM 4300: ");

            try
            {
                int grade = Convert.ToInt32(Console.ReadLine());

                if ((grade >= 90) && (grade <= 100))
                {
                    Console.WriteLine("Your letter grade will be a A.");
                }
                else if ((grade >= 80) && (grade <= 89))
                {
                    Console.WriteLine("Your letter grade will be a B");
                }
                else if ((grade >= 70) && (grade <= 79))
                {
                    Console.WriteLine("Your letter grade will be a C");
                }
                else if ((grade >= 60) && (grade <= 69))
                {
                    Console.WriteLine("Your letter grade will be a D");
                }
                else if ((grade >= 0) && (grade <= 59))
                {
                    Console.WriteLine("Your letter grade will be a F");
                }
            }
            catch
            {
                Console.WriteLine("Please input a number between 0 to 100");
            }
        }
    }
}