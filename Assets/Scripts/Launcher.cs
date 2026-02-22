using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public Transform LaunchPoint;
    
    public void Launch(Vector2 aimDirection)
    {
        // make the projectile
        GameObject projectile = Instantiate(ProjectilePrefab, LaunchPoint.position, Quaternion.identity);
        
        // send on its way
        LaunchProjectile(projectile, aimDirection);
    }

    private void LaunchProjectile(GameObject projectile, Vector2 aimDirection)
    {
        Rigidbody2D projectileRigidbody = projectile.GetComponent<Rigidbody2D>();
        projectileRigidbody.AddForce(aimDirection * 5, ForceMode2D.Impulse);
    }
}
