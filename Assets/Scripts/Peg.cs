using System;
using System.Collections.Generic;
using UnityEngine;

public class Peg : MonoBehaviour
{
    public List<Sprite> PegSprites;
    public Sounds Sounds;

    private int spriteNumber = 0;
    private SpriteRenderer spriteRenderer;

    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void Start()
    {
        spriteRenderer.sprite = PegSprites[0];
    }
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            HandleBallHit();
        }
    }

    private void HandleBallHit()
    {
        if (NoMoreColorsLeft())
        {
            DestroyPeg();
        }
        else
        {
            ChangeToNextColor();
        }
    }

    private void ChangeToNextColor()
    {
        spriteNumber = spriteNumber + 1;
        spriteRenderer.sprite = PegSprites[spriteNumber];
    }

    private void DestroyPeg()
    {
        Sounds.PlayCannonSound();
        Destroy(gameObject);
    }

    private bool NoMoreColorsLeft()
    {
        if (spriteNumber == 2)
            return true;
        return false;
    }
}
