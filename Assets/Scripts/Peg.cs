using System;
using UnityEngine;

public class Peg : MonoBehaviour
{
    public Sprite BlueSprite;
    public Sprite RedSprite;
    public Sprite GreenSprite;

    private int spriteNumber = 0;
    private SpriteRenderer spriteRenderer;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = GreenSprite;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = RedSprite;
        }
        spriteNumber = spriteNumber + 1;
    }

    private void DestroyPeg()
    {

    }

    private bool NoMoreColorsLeft()
    {
        if (spriteNumber == 2)
            return true;
        return false;
    }
}
