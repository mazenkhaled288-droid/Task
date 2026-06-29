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
Task 2 :
namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> letters= new List<string>();
          try
            {
                string text = Console.ReadLine();
                checkVowels(text);
                Console.WriteLine("Success! The string contains vowels.");
            }
            catch
            {
                Console.WriteLine("Catch problem");
            }
            static void checkVowels(string text)
            {
                string lowerText=text.ToLower();

                string vowels = "aeiou";

                bool hasvowel = false;
                foreach(char c in lowerText)
                {
                    if(vowels.Contains(c))
                    {
                        hasvowel=true;
                        break;
                    }
                }
                if(!hasvowel)
                {
                    throw new Exception("Not Exist");
                }
            }
        }
    }
}

