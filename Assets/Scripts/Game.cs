using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup StartMenuCanvasGroup;
    private static bool isGameStarted = true;

    public void Start()
    {
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
    }
    
    public void OnStartButtonClicked()
    {
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
        isGameStarted = true;
    }
    
    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
    
    public static bool IsGameNotStarted()
    {
        return !isGameStarted;
    }
}