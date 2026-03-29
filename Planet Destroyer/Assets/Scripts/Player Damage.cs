
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public float damage;
    public Playerhealth health;
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("obstacle"))
        {
            health.TakeDamage(damage);
            sprite.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collide)
    {
        Color normalColour;
        if (ColorUtility.TryParseHtmlString("#58DEFF", out normalColour))
        {
            sprite.color = normalColour;
        }
    }
}
