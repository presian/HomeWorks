using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixOfPalindromes
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string[,] matrix = new string[r, c];

        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = " " + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);
            } 
        }
        for (int hight = 0; hight < r; hight++)
        {
            for (int width = 0; width < c; width++)
            {
                Console.Write(matrix[hight, width]);
            }
            Console.WriteLine();
        }
    }
}
