using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip HitSound;

    private AudioSource audioSource;
    
    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();    
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Peg"))
        {
            audioSource.PlayOneShot(HitSound);
            audioSource.pitch = audioSource.pitch + 0.1f;
        }
    }
}
