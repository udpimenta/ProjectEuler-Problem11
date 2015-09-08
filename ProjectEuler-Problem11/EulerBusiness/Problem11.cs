using System;
using System.IO;
using System.Linq;

namespace EulerBusiness
{
    /// <summary>Euler Problem #11</summary>
    public class Problem11
    {

        #region public

        public int Calc(string Grid)
        {
            return Calc(ReadFromString(Grid));
        }

        public int Calc(int[,] Grid)
        {
            var rows = Grid.GetLength(0);
            var columns = Grid.GetLength(1);
            var result = 0;
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    // direita para esquerda
                    if (column < columns - 3)
                    {
                        result = Math.Max(result, Grid[row, column] * Grid[row, column + 1] * Grid[row, column + 2] * Grid[row, column + 3]);
                    }


                    if (row < rows - 3)
                    {
                        // baixo par cima
                        result = Math.Max(result, Grid[row, column] * Grid[row + 1, column] * Grid[row + 2, column] * Grid[row + 3, column]);

                        // diagonal baixo para direita
                        if (column < columns - 3)
                        {
                            result = Math.Max(result, Grid[row, column] * Grid[row + 1, column + 1] * Grid[row + 2, column + 2] * Grid[row + 3, column + 3]);
                        }
                            
                        // diagonal baixo par esquerda
                        if (column > 3)
                        {
                            result = Math.Max(result, Grid[row, column] * Grid[row + 1, column - 1] * Grid[row + 2, column - 2] * Grid[row + 3, column - 3]);
                        }
                            
                    }
                }
            }

            return result;
        }

        public int CalcFromFileName(string filename)
        {
            return Calc(ReadFromFileName(filename));
        }

        #endregion



        #region private

        private int[,] ReadFromString(string Grid)
        {
            Grid = Grid.Replace(",", "");
            Grid = Grid.Replace(";", "");
            Grid = Grid.Replace("\r", "");
            return To2D<int>(Grid
                .Split('\n')
                .Select(t => t.Split(' ')
                .Where(t1 =>
                {
                    int i = 0;
                    return int.TryParse(t1, out i);
                }).Select(int.Parse).ToArray()).ToArray());
        }

        private int[,] ReadFromFileName(string fileName)
        {
            int lines = 0;
            string line;
            string[] linePs;

            var r = new StreamReader(fileName);
            while (r.ReadLine() != null)
            {
                lines++;
            }

            var Grid = new int[lines, lines];

            r.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = r.ReadLine()) != null)
            {
                linePs = line.Split(' ');
                for (int i = 0; i < linePs.Length; i++)
                {
                    Grid[j, i] = int.Parse(linePs[i]);
                }
                j++;
            }

            r.Close();

            return Grid;
        }

        private T[,] To2D<T>(T[][] source)
        {
            try
            {
                int first = source.Length;

                int second = source.GroupBy(row => row.Length).Single().Key;

                var result = new T[first, second];

                for (int i = 0; i < first; ++i)
                {
                    for (int j = 0; j < second; ++j)
                    {
                        result[i, j] = source[i][j];
                    }
                }
                    

                return result;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Dados irregulares.");
            }
        }

        #endregion

    }
}