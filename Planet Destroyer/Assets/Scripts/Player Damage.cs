using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public float damage;
    public Playerhealth health;

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("obstacle"))
        {
            health.TakeDamage(damage);
        }
    }
}
