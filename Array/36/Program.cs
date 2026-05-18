char[][] board = { ['5','4','.','.','7','.','.','.','.' ]
                  ,['6','.','.','1','9','5','.','.','.']
                  ,['.','9','8','.','.','.','.','6','.']
                  ,['8','.','.','.','6','.','.','.','3']
                  ,['4','.','.','8','.','3','.','.','1']
                  ,['7','.','.','.','2','.','.','.','6']
                  ,['.','6','.','.','.','.','2','8','.']
                  ,['.','.','.','4','1','9','.','.','5']
                  ,['.','.','.','.','8','1','.','7','9'] };

Solution Solution = new();

Console.WriteLine(Solution.IsValidSudoku(board));

public class Solution
{
    private bool Check(int start_i, int end_i, int start_j, int end_j, char[][] board)
    {
        for (int i = start_i; i < end_i; i++)
        {
            HashSet<char> set = [];
            for (int j = start_j; j < end_j; j++)
            {
                if (board[i][j] != '.')
                {
                    if (!set.Add(board[i][j]))
                        return false;
                }
            }
        }

        for (int i = start_i; i < end_i; i++)
        {
            HashSet<char> set = [];
            for (int j = start_j; j < end_j; j++)
            {
                if (board[j][i] != '.')
                {
                    if (!set.Add(board[j][i]))
                        return false;
                }
            }
        }
        return true;
    }

    private bool Check1(int start_i, int end_i, int start_j, int end_j, char[][] board)
    {
        HashSet<char> set = [];
        for (int i = start_i; i < end_i; i++)
        {
            for (int j = start_j; j < end_j; j++)
            {
                if (board[i][j] != '.')
                {
                    if (!set.Add(board[i][j]))
                        return false;
                }
            }
            
        }
        return true;
    }

    public bool IsValidSudoku(char[][] board)
    {
        if (!Check(0, 9, 0, 9, board))
            return false;

        if (!Check1(0, 3, 0, 3, board))
            return false;

        if (!Check1(0, 3, 3, 6, board))
            return false;

        else if (!Check1(0, 3, 6, 9, board))
            return false;

        else if (!Check1(3, 6, 0, 3, board))
            return false;
        
        else if (!Check1(3, 6, 3, 6, board))
            return false;
        
        else if (!Check1(3, 6, 6, 9, board))
            return false;

        else if (!Check1(6, 9, 0, 3, board))
            return false;
        
        else if (!Check1(6, 9, 3, 6, board))
            return false;
        
        else if (!Check1(6, 9, 6, 9, board))
            return false;

        return true;
    }
}