using UnityEngine;

public class PlanetDamage : MonoBehaviour
{
    public float planetHealth;

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("bullet"))
        {   
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

    private void DestroyPlanet()
    {
        //destroy planet
        Destroy(this.gameObject);
    }
}
