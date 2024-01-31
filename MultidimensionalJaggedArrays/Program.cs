namespace MultidimensionalJaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = 2;
            int numCols = 2;

            string[,] names = new string[numRows, numCols];
            names[0, 0] = "Erin";
            names[0, 1] = "Cascioli";
            names[1, 0] = "Will";
            names[1, 1] = "Duprey";

            //int howManyRows = names.GetLength(0);

            for (int r = 0; r < numRows; r++)
            {
                for (int c = 0; c < numCols; c++)
                {
                    Console.Write(names[r,c] + " ");
                }
                Console.WriteLine();
            }






            
            int numRowsJagged = 2;
            string[][] namesJagged = new string[numRowsJagged][];
            namesJagged[0] = new string[2];
            namesJagged[1] = new string[3];

            namesJagged[0][0] = "A";
            namesJagged[0][1] = "B";

            namesJagged[1][0] = "C";
            namesJagged[1][1] = "D";
            namesJagged[1][2] = "E";



            //int arrayRows = names.GetLength(0);
            //int arrayCols = names.GetLength(1);

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Console.Write(names[row,col] + " ");
                }

                Console.WriteLine();
            }

            for (int row = 0; row < numRowsJagged; row++)
            {
                for (int col = 0; col < namesJagged[row].Length; col++)
                {
                    Console.Write(namesJagged[row][col] + " ");
                }

                Console.WriteLine();
            }
            
        }
    }
}