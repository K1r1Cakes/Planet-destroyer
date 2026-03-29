using System.Net;
using UnityEngine;

public class Destroy : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("obstacle") || collide.CompareTag("planet"))
        {
            Destroy(collide.gameObject);
        }
    }
}
