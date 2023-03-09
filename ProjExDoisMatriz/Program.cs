using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = new int[5, 5];
        
        for(int line = 0; line<5; line++)
        {
            for(int column = 0; column < 5; column++)
            {
                Console.Write($" Matriz[{line},{column}] : ");
                matrix[line, column] = int.Parse(Console.ReadLine());
            }
        }

        SomaColuna(matrix);
        SomaLinha(matrix);
        SomaDiagonal(matrix);
        SomaDiagonalSec(matrix);



        void SomaColuna(int[,] mat)
        {
            int[] somaColuna = new int[5];
            {
                for(int column = 0; column<5; column++)
                {
                    for(int line = 0; line < 5; line++)
                    {
                        somaColuna[column] = somaColuna[column] + mat[line, column];
                    }
                    Console.WriteLine($"Soma da coluna {column+1} = {somaColuna[column]}");
                }
            }
        }

        void SomaLinha(int[,] mat)
        {
            int[] somaLinha = new int[5];
            {
                for (int line = 0; line < 5; line++)
                {
                    for (int column = 0; column < 5; column++)
                    {
                        somaLinha[line] = somaLinha[line] + mat[line, column];
                    }
                    Console.WriteLine($"Soma da linha {line + 1} = {somaLinha[line]}");
                }
            }
        }

        void SomaDiagonal(int[,] mat)
        {
            int somaDiagonal = 0;
            for(int x = 0; x < 5; x++)
            {
                somaDiagonal = somaDiagonal + mat[x, x];
            }
            Console.WriteLine($"Soma da diagonal = {somaDiagonal}");

        }

        void SomaDiagonalSec(int[,] mat)
        {
            int somaDiagonalSec = 0;
            for (int x = 0; x < 5; x++)
            {
                somaDiagonalSec = somaDiagonalSec + mat[x, 5 - x];
            }
            Console.WriteLine($"Soma da diagonal secundária = {somaDiagonalSec}");
        }
    }
}