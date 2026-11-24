using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string? text;
        do
        {
            Console.Write("Жолды енгізіңіз: ");
            text = Console.ReadLine();
            if (text is null)
            {
                Console.WriteLine("Енгізу аяқталды.");
                return;
            }

            if (text.Length == 0)
                Console.WriteLine("Бос жол енгізілді. Қайталап көріңіз.");
        }
        while (text.Length == 0);

        string result = CollapseSpaces(text);
        Console.WriteLine($"Бастапқы жол: [{text}]");
        Console.WriteLine($"Нәтиже:       [{result}]");
    }

    static string CollapseSpaces(string text)
    {
        string result = "";
        bool previousWasSpace = false;

        for (int i = 0; i < text.Length; i++)
        {
            char current = text[i];
            if (current == ' ')
            {
                if (!previousWasSpace)
                    result += current;
                previousWasSpace = true;
            }
            else
            {
                result += current;
                previousWasSpace = false;
            }
        }

        return result;
    }
}
