using UnityEngine;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;
    public GameObject panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf)
        {
            PauseController.setPause(true);
        }
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;

        if (healthAmount  <= 0)
        {
            panel.SetActive(true);
            Debug.Log("Lose");
        }
    }
}
