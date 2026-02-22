using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text ScoreText;
    
    public void ShowScore(int score)
    {
        ScoreText.text = score.ToString();
    }
}
