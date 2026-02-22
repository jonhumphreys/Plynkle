using UnityEngine;

public class MouseFacer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // figure out the angle
        float angle = GetAngle();

        // rotate us
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    private float GetAngle()
    {
        Vector3 mouseWorldPosition = MouseUtils.GetMouseWorldPosition(Camera.main);
        float angle = DirectionUtils.GetAngle(mouseWorldPosition, transform.position);
        angle = ConstrainAngle(angle);
        
        return angle;
    }

    private float ConstrainAngle(float angle)
    {
        if (angle > 75)
            angle = 75;
        if (angle < -75)
            angle = -75;
        return angle;
    }
}
