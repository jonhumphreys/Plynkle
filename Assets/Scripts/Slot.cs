using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Slot : MonoBehaviour
{
    public int Points = 10;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            OnBallEntered(other);
        }
    }

    private void OnBallEntered(Collider2D ball)
    {
        ScorePoints();
    }

    private void ScorePoints()
    {
        print("scored " + Points);
        ScoreKeeper.AddScore(Points);
    }
}
