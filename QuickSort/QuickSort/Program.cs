using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            char[] numberInArray;
            numberInArray =  ReadLineFromConsole().ToCharArray();
            WriteStringInConsole(numberInArray);
            Pause();

          
            string ReadLineFromConsole()
            {
                return (Console.ReadLine());
            }
            void WriteStringInConsole(char [] Word)
            {
                for (int i = 0; i < Word.Length; i++)
                Console.Write(Word[i]);
            }
            void Pause()
            {
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }

            void QuickSort(char[] word, int initPos,int FinalPos)
            {
               /* int pivot = word.Length-1;
                char[] auxWord = auxWord[]; 
                for (int i = 0;i < word.Length; i++)
                {
                    if (word[i]< word[FinalPos])
                }*/
            }
        }

     
    }
}
