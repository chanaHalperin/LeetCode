public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
        Array.Sort(players);
        Array.Sort(trainers);
        int matchings = 0, i = 0, j = 0;
        while(i != players.Length && j != trainers.Length){
              if(players[i] <= trainers[j]){
                matchings++;
                i++;
                j++;
              }
              else{
                j++;
              }
        }
        return matchings;
    }
}