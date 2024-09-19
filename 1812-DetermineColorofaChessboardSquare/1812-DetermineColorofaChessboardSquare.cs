public class Solution {
    public bool SquareIsWhite(string coordinates) {
        bool[,] chessboard = new bool[8, 8];
        bool prevSquare = false;
        int[] cords = new int[2];
        cords = ChessCordinates(coordinates);

        for(int i = 0; i < 8; i++)
        {
            prevSquare = !prevSquare;
            for(int j = 0; j < 8; j++)
            {
                chessboard[i, j] = !prevSquare;
                prevSquare = chessboard[i, j];
            }
        }
        return chessboard[cords[0], cords[1]];
    }

    public int[] ChessCordinates(string coordinates)
    {
        string column = coordinates.Substring(0, 1);
        int[] coordsNum = new int[2];
        coordsNum[1] = Int32.Parse(coordinates.Substring(1, 1)) - 1;

        switch(column){
            case "a":
                coordsNum[0] = 0;
                break;

            case "b":
                coordsNum[0] = 1;
                break;

            case "c":
                coordsNum[0] = 2;
                break;

            case "d":
                coordsNum[0] = 3;
                break;

            case "e":
                coordsNum[0] = 4;
                break;

            case "f":
                coordsNum[0] = 5;
                break;

            case "g":
                coordsNum[0] = 6;
                break;

            case "h":
                coordsNum[0] = 7;
                break;

            default:
                break;
        }
        return coordsNum;
    }
}