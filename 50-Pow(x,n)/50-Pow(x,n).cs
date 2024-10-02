public class Solution {
    public double MyPow(double x, int n) {
        double result = x;
        double division = x;

        if(n == 0) return 1;
        if(x == 1) return 1;
        if(x == -1){
            if((n % 2) == 0) return 1;
            if((n % 2) == 1) return -1;
        }
        if(n < -100000) return 0;

        while(n < 0){
            result = 1 / division;
            division *= x;
            n++;
        }
        while(n > 1){
            result *= x;
            n--;
        }

        return result;
    }
}