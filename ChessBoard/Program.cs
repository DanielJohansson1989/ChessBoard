// Daniel Johansson SUT23

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Chess Board! \nPlease enter the desired number of rows on the board:");

            int numberOfRows = Convert.ToInt32(Console.ReadLine());


            Console.Write("Type in a symbol that should represent the black tiles:");

            string blackTiles = Console.ReadLine();


            Console.Write("Type in a symbol that should represent the white tiles:");

            string whiteTiles = Console.ReadLine();


            for (int i = 0; i < numberOfRows; i++) // Loop that controls number of rows printed out
            {
                if (i % 2 == 0)
                {
                    /*
                     * This loop prints a row with black and white tiles.
                     * Number of tiles is determined by user input in variable "numberOfRows".
                     * This row starts with black.
                     */
                    for (int j = 0; j < numberOfRows; j++)
                    {
                        var tileColor = j % 2 == 0 ? blackTiles : whiteTiles;
                        Console.Write(tileColor);
                    }
                    Console.WriteLine(); // Jumps one line down so the next itteration start on a new row.
                }

                else
                {
                    /*
                     * This loop prints a row with black and white tiles.
                     * Starts with white
                     */
                    for (int j = 0; j < numberOfRows; j++)
                    {
                        var tileColor = j % 2 == 1 ? blackTiles : whiteTiles;
                        Console.Write(tileColor);
                    }
                    Console.WriteLine(); // Jumps one line down so the next itteration starts on a new row.
                }
            }
        }
    }
}