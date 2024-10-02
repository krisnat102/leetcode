public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char, int> balloon = new Dictionary<char, int>();
        balloon.Add('b', 0);
        balloon.Add('a', 0);
        balloon.Add('l', 0);
        balloon.Add('o', 0);
        balloon.Add('n', 0);

        foreach(var letter in text){
            if(balloon.ContainsKey(letter)) balloon[letter]++;
        }
        return Math.Min(Math.Min(Math.Min(balloon['b'], balloon['a']), Math.Min(balloon['l'] / 2, balloon['o'] / 2)), balloon['n']);
    }
}