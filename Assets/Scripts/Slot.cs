using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Slot : MonoBehaviour
{
    public int Points = 10;
    public UI Ui;
    public GameObject FireworksParticlePrefab;
    public Sounds Sounds;
    
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
        SpawnParticles(ball);
        PlayFireworksSound();
    }

    private void PlayFireworksSound()
    {
        Sounds.PlayFireworksSound();
    }

    private void SpawnParticles(Collider2D ball)
    {
        Vector3 particlePosition = GetParticlePosition(ball);
        
        Instantiate(FireworksParticlePrefab, particlePosition, Quaternion.identity);
    }

    private Vector3 GetParticlePosition(Collider2D ball)
    {
        Vector3 particlePosition = ball.transform.position;
        particlePosition.y = particlePosition.y + 0.25f;
        return particlePosition;
    }

    private void ScorePoints()
    {
        ScoreKeeper.AddScore(Points);
        Ui.ShowScore(ScoreKeeper.GetScore());
    }
}
