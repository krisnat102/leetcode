public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < 9; i++)
    {
        var hashSetRows = new HashSet<int>();
        var hashSetColumns = new HashSet<int>();
        var hashSetCells = new HashSet<int>();

        for (int j = 0; j < 9; j++)
        {
            if (board[i][j] != '.' && !hashSetRows.Add(board[i][j] - '0'))
            {
                return false;
            }

            if (board[j][i] != '.' && !hashSetColumns.Add(board[j][i] - '0'))
            {
                return false;
            }

            int cellRowStart = 3 * (i / 3);
            int cellColStart = 3 * (i % 3);
            int rowIndex = cellRowStart + j / 3;
            int colIndex = cellColStart + j % 3;
            if (board[rowIndex][colIndex] != '.' && !hashSetCells.Add(board[rowIndex][colIndex] - '0'))
            {
                return false;
            }
        }
    }
    return true;
}
}