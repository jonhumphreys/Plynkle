using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLauncher : MonoBehaviour
{
    public Launcher Launcher;
    public Sounds Sounds;
    
    // Update is called once per frame
    void Update()
    {
        if (Game.IsGameNotStarted())
            return;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Launch();
        }
    }

    private void Launch()
    {
        Vector2 aimDirection = GetAimDirection();
        Launcher.Launch(aimDirection);
        Sounds.PlayCannonSound();
    }

    private Vector2 GetAimDirection()
    {
        Vector3 mouseWorldPosition = MouseUtils.GetMouseWorldPosition(Camera.main);
        Vector2 aimDirection =  DirectionUtils.GetAimDirection(mouseWorldPosition, transform.position);
        return aimDirection;
    }
}
