namespace ConsoleApp112
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Check Positive OR Negative
            Console.WriteLine("Enter The Number : ");
            float number = Convert.ToSingle(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("The Number Is Negative");
            }
            else if(number > 0)
                {
                Console.WriteLine("The Number Is Positive");
                }
            else
            {
                Console.WriteLine("The Number Is Zero");
            }
                #endregion
            }
        }
    }
