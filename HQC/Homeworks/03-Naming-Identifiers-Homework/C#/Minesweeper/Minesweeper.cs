using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mini4ki
{
    public class Minesweeper
    {
        public class RankList
        {
            private string playerName;
            private int points;

            public string Playername
            {
                get
                {
                    return playerName;
                }

                set
                {
                    playerName = value;
                }
            }

            public int Points
            {
                get
                {
                    return this.points;
                }

                set
                {
                    this.points = value;
                }
            }

            public RankList()
            {
            }

            public RankList(string name, int points)
            {
                this.Playername = name;
                this.Points = points;
            }
        }

        private static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] mines = CreateMines();
            int moveCounter = 0;
            bool mineExploded = false;
            List<RankList> playersList = new List<RankList>(6);
            int row = 0;
            int column = 0;
            bool firstFlag = true;
            const int MAX_MOVES = 35;
            bool secondFlag = false;

            do
            {
                if (firstFlag)
                {
                    Console.WriteLine(
                        "Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki."
                        + " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    PrintField(gameField);
                    firstFlag = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column)
                        && row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Ranking(playersList);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        mines = CreateMines();
                        PrintField(gameField);
                        mineExploded = false;
                        firstFlag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                PlayerTurn(gameField, mines, row, column);
                                moveCounter++;
                            }

                            if (MAX_MOVES == moveCounter)
                            {
                                secondFlag = true;
                            }
                            else
                            {
                                PrintField(gameField);
                            }
                        }
                        else
                        {
                            mineExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (mineExploded)
                {
                    PrintField(mines);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", moveCounter);
                    string playerName = Console.ReadLine();
                    RankList playerScore = new RankList(playerName, moveCounter);
                    if (playersList.Count < 5)
                    {
                        playersList.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < playersList.Count; i++)
                        {
                            if (playersList[i].Points < playerScore.Points)
                            {
                                playersList.Insert(i, playerScore);
                                playersList.RemoveAt(playersList.Count - 1);
                                break;
                            }
                        }
                    }

                    playersList.Sort((RankList player1, RankList player2) => player2.Playername.CompareTo(player1.Playername));
                    playersList.Sort((RankList player1, RankList player2) => player2.Points.CompareTo(player1.Points));
                    Ranking(playersList);

                    gameField = CreateGameField();
                    mines = CreateMines();
                    moveCounter = 0;
                    mineExploded = false;
                    firstFlag = true;
                }

                if (secondFlag)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    PrintField(mines);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string playerName = Console.ReadLine();
                    RankList playerPoints = new RankList(playerName, moveCounter);
                    playersList.Add(playerPoints);
                    Ranking(playersList);
                    gameField = CreateGameField();
                    mines = CreateMines();
                    moveCounter = 0;
                    secondFlag = false;
                    firstFlag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Ranking(List<RankList> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Playername, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void PlayerTurn(char[,] field, char[,] mines, int row, int column)
        {
            char minesCount = ProximateMineCounter(mines, row, column);
            mines[row, column] = minesCount;
            field[row, column] = minesCount;
        }

        private static void PrintField(char[,] gameField)
        {
            int fieldRows = gameField.GetLength(0);
            int fieldColumns = gameField.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < fieldRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < fieldColumns; j++)
                {
                    Console.Write(string.Format("{0} ", gameField[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] playField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> mineList = new List<int>();
            while (mineList.Count < 15)
            {
                Random random = new Random();
                int nextMine = random.Next(50);
                if (!mineList.Contains(nextMine))
                {
                    mineList.Add(nextMine);
                }
            }

            foreach (int mine in mineList)
            {
                int column = mine / columns;
                int row = mine % columns;
                if (row == 0 && mine != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playField[column, row - 1] = '*';
            }

            return playField;
        }

        private static void PrintNumberOfProximateMines(char[,] gameField)
        {
            int column = gameField.GetLength(0);
            int row = gameField.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (gameField[i, j] != '*')
                    {
                        char mineCount = ProximateMineCounter(gameField, i, j);
                        gameField[i, j] = mineCount;
                    }
                }
            }
        }

        private static char ProximateMineCounter(char[,] field, int row, int column)
        {
            int mineCount = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, column] == '*')
                {
                    mineCount++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, column] == '*')
                {
                    mineCount++;
                }
            }

            if (column - 1 >= 0)
            {
                if (field[row, column - 1] == '*')
                {
                    mineCount++;
                }
            }

            if (column + 1 < columns)
            {
                if (field[row, column + 1] == '*')
                {
                    mineCount++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (field[row - 1, column - 1] == '*')
                {
                    mineCount++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (field[row - 1, column + 1] == '*')
                {
                    mineCount++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (field[row + 1, column - 1] == '*')
                {
                    mineCount++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (field[row + 1, column + 1] == '*')
                {
                    mineCount++;
                }
            }

            return char.Parse(mineCount.ToString());
        }
    }
}