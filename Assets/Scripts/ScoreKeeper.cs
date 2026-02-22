using UnityEngine;

public static class ScoreKeeper
{
    private static int score = 0;
    
    public static int GetScore()
    {
        return score;
    }
    
    public static void AddScore(int amount)
    {
        score = score + amount;
        MonoBehaviour.print(score);
    }

    public static void ResetScore()
    {
        score = 0;
    }
}
