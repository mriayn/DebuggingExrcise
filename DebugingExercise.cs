using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        char[] textChar = text.ToString().ToCharArray();
        bool hasMatch = false;

        for (int i = 0; i < textChar.Length; i++)
        {
            if (textChar[i] == 'p')
            {
                hasMatch = true;

                int endIndex = jump;

                if (endIndex > text.Length)
                {
                    endIndex = text.Length;
                }

                string matchedString = text.Substring(i, endIndex+1);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
