using UnityEngine;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;
    public GameObject panel;
    public AudioSource audioSource;
    public AudioSource loseAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
        audioSource.Play();

        if (healthAmount  == 0)
        {
            panel.SetActive(true);
            loseAudio.Play();
            PauseController.setPause(true);
            Debug.Log("Lose");
        }
    }
}
