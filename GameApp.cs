using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CHANGELOG: 01/31/19: Began on App Dev. Created a test board to test logic
//           02/01/19: Created conditional statements that prevent a runtime error when input did not match what was needed.
//           02/02/19: Better optimizations for interacting with the array.
//           02/02/19: Optimized the methods for both player functionality.

//This is a TicTacToe game that you can play with two people. 
namespace TicTacToe
{
    class GameApp
    {

        static void Main(string[] args)
        {

            //Lay out the player and count variables
            Console.WriteLine("Welcome to TicTacToe!");


            //Print that the game is gonna begin
            Console.WriteLine("Let's begin");
            Console.WriteLine();
            //Initializes board with all 0s in the array containing it.
            TicTacToe.CreateBoard();
            //Begin player moves/game...
            TicTacToe.Player1Move();
            TicTacToe.Player2Move();
            TicTacToe.Player1Move();
            TicTacToe.Player2Move();
            TicTacToe.Player1Move();
            TicTacToe.Player2Move();
            TicTacToe.Player1Move();
            TicTacToe.Player2Move();
            TicTacToe.Player1Move();
            //By this time there should be a winner. If not, the next line executes and the app stops.
            TicTacToe.GameDraw();
            //End game if there is no winner.

        }
        //This method controls how player1's actions are intrepreted...

    }
    //Class containing all of the methods required to drive the game.
    class TicTacToe
    {
        //Initialization of variables that are used in the methods in this class.
        private static int[,] board;
        private static int a;
        private static int b;
        private static string player1;
        private static string player2;
        public static void CreateBoard() 
        {
            board = new int[3, 3];
        }

        public static void Player1Move()
            {
            //Asks for input as to where their 1 is placed on the board.
            Console.WriteLine("Player 1's turn!");
            Console.WriteLine("Which row do you want to occupy? Select 0 (first) - 2 (last)");
            //Take the input for the move.
            string playerMove = Console.ReadLine();

            //Conditional for user input so that there will be no runtime errors
            if (playerMove.Equals("0") || playerMove.Equals("1") || playerMove.Equals("2"))
            {
            } else
            {
                //The Writeline explains what this does
                Console.Clear();
                Console.WriteLine("Invalid Input. Redoing attempt...");
                playerMove.Equals(null);
                //Restarts the move
                Player1Move();
            }

            //COnverts input to an integer so that the game can know where to place the user's mark on the board.
            int a = Convert.ToInt32(playerMove);

            /*************The same as the part above but for the column**************/
            Console.WriteLine("Which column do you want to occupy? Select 0 (first) - 2 (last)");
            string playerMove2 = Console.ReadLine();
            if (playerMove2.Equals("0") || playerMove2.Equals("1") || playerMove2.Equals("2"))
            {
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Input. Redoing attempt...");
                playerMove2.Equals(null);
                Player1Move();
            }
            int b = Convert.ToInt32(playerMove2);
            /*************************************************************************/

            //Checks to see if the space has already been occupied.
            if (board[a, b] != 0)
            {
                Console.WriteLine("Try again! Space is occupied");
                Player1Move();
            }

            //Adds the space desired
            board[a, b] = 1;

            //Draws the board on the screen...
            TicTacToeTest();

            //Checks to see if the user won.
            WinCheck1();
        }
        
        //Functionality for the method below is EXACTLY the same as the one above. Only for second player though...
        public static void Player2Move()
        {
            Console.WriteLine("Player 2's turn!");
            Console.WriteLine("Which row do you want to occupy? Select 0 (first) - 2 (last)");
            string playerMove = Console.ReadLine();
            if (playerMove.Equals("0") || playerMove.Equals("1") || playerMove.Equals("2"))
            {
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Input. Redoing attempt...");
                Player2Move();
            }
            int a = Convert.ToInt32(playerMove);
            Console.WriteLine("Which column do you want to occupy? Select 0 (first) - 2 (last)");
            string playerMove2 = Console.ReadLine();
            if (playerMove2.Equals("0") || playerMove2.Equals("1") || playerMove2.Equals("2"))
            {
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Input. Redoing attempt...");
                Player2Move();
            }
            int b = Convert.ToInt32(playerMove2);
            if (board[a, b] != 0)
            {
                Console.WriteLine("Try again! Space is occupied");
                Player2Move();
            }
            board[a, b] = 2;
            TicTacToeTest();
            WinCheck2();
        }

        //Method below checks for a win from either player by checking the values of each space and seeing if they match up in lines...
        public static void WinCheck1()
        {

            if (board[0, 0] == 1 && board[0, 1] == 1 && board[0, 2] == 1)
            {
                Console.WriteLine("Player 1 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[1, 0] == 1 && board[1, 1] == 1 && board[1, 2] == 1)
            {
                Console.WriteLine("Player 1 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[2, 0] == 1 && board[2, 1] == 1 && board[2, 2] == 1)
            {
                Console.WriteLine("Player 1 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[0, 0] == 1 && board[1, 0] == 1 && board[2, 0] == 1)
            {
                Console.WriteLine("Player 1 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[0, 1] == 1 && board[1, 1] == 1 && board[2, 1] == 1)
            {
                Console.WriteLine("Player 1 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[0, 2] == 1 && board[1, 2] == 1 && board[2, 2] == 1)
            {
                Console.WriteLine("Player 1 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1)
            {
                Console.WriteLine("Player 1 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[0, 2] == 1 && board[1, 1] == 1 && board[2, 0] == 1)
            {
                Console.WriteLine("Player 1 wins!!");
                System.Environment.Exit(1);
            }
        }

        //Same as above, but for second player...
        public static void WinCheck2()
        {

            if (board[0, 0] == 2 && board[0, 1] == 2 && board[0, 2] == 2)
            {
                Console.WriteLine("Player 2 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[1, 0] == 2 && board[1, 1] == 2 && board[1, 2] == 2)
            {
                Console.WriteLine("Player 2 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[2, 0] == 2 && board[2, 1] == 2 && board[2, 2] == 2)
            {
                Console.WriteLine("Player 2 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[0, 0] == 2 && board[1, 0] == 2 && board[2, 0] == 2)
            {
                Console.WriteLine("Player 2 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[0, 1] == 2 && board[1, 1] == 2 && board[2, 1] == 2)
            {
                Console.WriteLine("Player 2 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[0, 2] == 2 && board[1, 2] == 2 && board[2, 2] == 2)
            {
                Console.WriteLine("Player 2 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 2)
            {
                Console.WriteLine("Player 2 wins!!");
                System.Environment.Exit(1);
            }
            else if (board[0, 2] == 2 && board[1, 1] == 2 && board[2, 0] == 2)
            {
                Console.WriteLine("Player 2 wins!!");
                System.Environment.Exit(1);
            }
        }
            
        public static void TicTacToeTest()
        {
            //Print the board!
            Console.Clear();
            for (int i=0; i<3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", board[i, j]);
                }
                Console.WriteLine();
            }
        }

        //Method below just clears the screen and screams DRAW!!
        public static void GameDraw()
        {
            Console.Clear();
            Console.WriteLine("Draw!!");
        }
    }
}
