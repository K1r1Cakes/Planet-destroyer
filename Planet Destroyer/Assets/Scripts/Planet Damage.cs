using UnityEngine;

public class PlanetDamage : MonoBehaviour
{
    public float planetHealth;
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("bullet"))
        {   
            sprite.color = Color.red;

            if (planetHealth > 1)
            {
                planetHealth = planetHealth - 10;
                Debug.Log(planetHealth);
            }
            else
            {
                DestroyPlanet();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collide)
    {
        Color normalColour;
        if (ColorUtility.TryParseHtmlString("#AFE89B", out normalColour))
        {
            sprite.color = normalColour;
        }
    }

    private void DestroyPlanet()
    {
        //destroy planet
        Destroy(this.gameObject);
    }
}
