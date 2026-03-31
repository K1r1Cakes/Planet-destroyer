using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 2f;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (PauseController.isGamePaused)
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }
       rb.linearVelocity = Vector2.left * (speed + gameManager.speedMultiplier);
    }
}
