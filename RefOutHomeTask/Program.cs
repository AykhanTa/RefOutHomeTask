namespace RefOutHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, -3, -4, 5, 6 };
            //MinusElementsArr(arr);

            //string word =Console.ReadLine();
            //int n=int.Parse(Console.ReadLine());
            //Repeat(word,n);

            //Console.WriteLine(IsPalindrome("atat"));

            //string word=Console.ReadLine();
            //Console.WriteLine(RemoveRepeatedChar(word));

            //string word = Console.ReadLine();
            //ReversedString(word);

            string word = "Cavid yaxsi oglandi";
            SplitString(word);

        }
        static void MinusElementsArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
                Console.Write(arr[i] + " ");
            }
        }

        static void Repeat(string word, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(word);
            }
        }

        static bool IsPalindrome(string s)
        {
            string newString = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                newString += s[i];
            }
            if (newString == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string RemoveRepeatedChar(string word)
        {
            string newString = "";
            for (int i = 0; i < word.Length; i++)
            {
                bool repeated = false;
                for (int j = 0; j < newString.Length; j++)
                {
                    if (word[i] == newString[j])
                    {
                        repeated = true;
                        break;
                    }
                }
                if (!repeated)
                {
                    newString += word[i];
                }
            }
            return newString;
        }

        static void ReversedString(string word)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }

        static void SplitString(string word)
        {
            string newString = string.Empty; 
            word += " ";

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    newString += word[i];
                }
                else
                {
                    if (newString.Length>0)
                    {
                        Console.WriteLine(newString);
                        newString = "";
                    }
                }
            }
        }
    }
}