namespace Word_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] board = [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']];
            string word = "ABCCED";

            Console.WriteLine(Exist(board, word));
            Console.ReadKey();
        }
        public static bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int k = 0; k < board[0].Length; k++)
                {
                    if (board[i][k] == word[0] && Search(board, i, k, word, 0))
                        return true;
                }
            }
            return false;
        }

        public static bool Search(char[][] board, int boardY, int boardX, string word, int currentCharIndex)
        {
            char val = board[boardY][boardX];

            if (val != word[currentCharIndex])
                return false;

            //Keep track of already used cells by temporarily changing the value
            board[boardY][boardX] = '$';

            //We have a match
            if (word.Length - 1 == currentCharIndex)
                return true;

            if (boardY > 0 && Search(board, boardY - 1, boardX, word, currentCharIndex + 1))
                return true;

            if (boardX + 1 < board[0].Length && Search(board, boardY, boardX + 1, word, currentCharIndex + 1))
                return true;

            if (boardY + 1 < board.Length && Search(board, boardY + 1, boardX, word, currentCharIndex + 1))
                return true;

            if (boardX > 0 && Search(board, boardY, boardX - 1, word, currentCharIndex + 1))
                return true;

            board[boardY][boardX] = val;

            return false;
        }
    }
}
