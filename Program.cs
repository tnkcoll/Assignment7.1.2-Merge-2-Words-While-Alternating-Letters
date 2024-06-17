using System.Text;

namespace Assignment7._1._2_Merge_2_Words_While_Alternating_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqrstln";

            Console.WriteLine(MergeStringsByLetter(word1, word2));


        }

        static string MergeStringsByLetter(string w1, string w2)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            int j = 0;

            //Iterate through each letter of each word as long as either i or j has not reached the end of their respective words.
            while (i < w1.Length || j < w2.Length)
            {
                //Use two if statements to individually see if there are any more letters in each word.
                //If one word is longer than the other, having the two if statement will not cause the
                //shorter word iteration to throw an "out of bounds" exception.
                if (i < w1.Length)
                {
                    sb.Append(w1[i]);
                }

                if (j < w2.Length) 
                {
                    sb.Append(w2[j]);
                }

                i++;
                j++;
            }

            return sb.ToString();
        }
    }
}
