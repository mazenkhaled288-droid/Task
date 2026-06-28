namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    int num = Convert.ToInt16(Console.ReadLine());

                    if(numbers.Contains(num))
                    {
                        throw new Exception("new problem");
                    }
                    numbers.Add(num);

                }

            }
            catch (Exception ex)
            {           

            Console.WriteLine("Catch problem");

            }

            }
    }
}
