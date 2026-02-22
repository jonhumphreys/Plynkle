using System;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip CannonSound;
    public AudioClip PegDestroySound;
    public AudioClip FireworksSound;
    
    private AudioSource audioSource;
    
    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();    
    }
    
    public void PlayCannonSound()
    {
        audioSource.PlayOneShot(CannonSound);
    }
    
    public void PlayPegDestroySound()
    {
        audioSource.PlayOneShot(PegDestroySound);
    }
    
    public void PlayFireworksSound()
    {
        audioSource.PlayOneShot(FireworksSound);
    }
}
