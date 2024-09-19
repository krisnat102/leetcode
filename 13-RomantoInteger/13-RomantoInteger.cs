public class Solution {
    public int RomanToInt(string input) {
        char prev = ' ';
        int sum = 0;
        foreach (char c in input)
        {
            if (prev != ' ' && Convert(prev) < Convert(c))
            {
                sum -= Convert(prev);
            }
            else if (prev != ' ')
            {
                sum += Convert(prev);
            }
            prev = c;
        }
        sum += Convert(input[input.Length - 1]);
        return sum;
    }

    int Convert(char c)
    {
        switch (c)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                throw new ArgumentException("Invalid");
        }
    }
}