public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int posFlowers = 0;
        if(n == 0) return true;
        if(flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1) return true;
        else if(flowerbed.Length == 1) return false;

        for(int i = 0; i < flowerbed.Length; i++) {
            if(i == 0){
                if(flowerbed[i] == 0 && flowerbed[i + 1] == 0){
                    flowerbed[i] = 1;
                    posFlowers++;
                }
            }
            else if(i == flowerbed.Length - 1){
                if(flowerbed[i] == 0 && flowerbed[i - 1] == 0){
                    flowerbed[i] = 1;
                    posFlowers++;
                }
            }
            else{
                if(flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0){
                    flowerbed[i] = 1;
                    posFlowers++;
                }
            }
        }
        return n <= posFlowers;
    }
}