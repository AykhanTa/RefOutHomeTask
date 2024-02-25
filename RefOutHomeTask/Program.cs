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


        }
        static  void MinusElementsArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
                Console.Write(arr[i]+" ");
            }
        }

        static void Repeat(string word, int count)
        {
            for (int i = 0; i <count; i++)
            {
                Console.Write(word);
            }
        }

        static bool IsPalindrome(string s)
        {
            string newString=string.Empty;
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

    }
}