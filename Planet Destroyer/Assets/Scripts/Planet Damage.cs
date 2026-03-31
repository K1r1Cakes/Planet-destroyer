using UnityEngine;

public class PlanetDamage : MonoBehaviour
{
    public float planetHealth;
    private SpriteRenderer sprite;
    public AudioSource audioSource;


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
            audioSource.Play();
            if (planetHealth > 0)
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
       
        Invoke(nameof(resetColor), 0.1f);
    }

    /*private void OnTriggerExit2D(Collider2D collide)
    {
        Color normalColour;
        if (ColorUtility.TryParseHtmlString("#AFE89B", out normalColour))
        {
            sprite.color = normalColour;
        }
    }*/

    void resetColor()
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
