using UnityEngine;

public class PlanetDamage : MonoBehaviour
{
    public float planetHealth;
    private SpriteRenderer sprite;


    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        
        Debug.Log(sprite);
    }

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("bullet"))
        {   
            Debug.Log("Triggered");

            sprite.color = Color.red;

            if (planetHealth > 1)
            {
                planetHealth = planetHealth - 10;
                Debug.Log(planetHealth);
            }
            else
            {
                DestroyPlanet();
                ScoreManager.instance.AddPoint();
            }
        }

        Bullet bullet = collide.GetComponent<Bullet>();
        if (bullet != null)
        {
            bullet.BulletHit(); 
        }
       

    }

    /*private void OnTriggerExit2D(Collider2D collide)
    {
        Color normalColour;
        if (ColorUtility.TryParseHtmlString("#AFE89B", out normalColour))
        {
            sprite.color = normalColour;
        }
    }*/

    private void DestroyPlanet()
    {
        //destroy planet
        Destroy(this.gameObject);
    }
}
