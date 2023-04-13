using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPicNumber = 52;
            int picsInRow = 3;
            int filledRows = totalPicNumber / picsInRow;
            int remainingPics = totalPicNumber % picsInRow;

            Console.WriteLine($"Общее количество картинок: {totalPicNumber}; количество картинок в ряду: {picsInRow}");
            Console.WriteLine($"Количество полностью заполненных рядов: {filledRows}");
            Console.WriteLine($"Количество оставшихся картинок: {remainingPics}");
            Console.ReadKey();
        }
    }
}

