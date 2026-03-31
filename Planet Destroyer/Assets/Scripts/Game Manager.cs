using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] spawnPointsP;
    public float Obstacletimer;
    public float planetTimer;
    public float timeBetweenSpawns;
    public float timeBetweenSpawnsPlanet;
    public GameObject obstacle;
    public GameObject planet;
    public float speedMultiplier;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseController.isGamePaused)
        {
            return;
        }
        speedMultiplier += Time.deltaTime * 0.1f;
        
        Obstacletimer += Time.deltaTime;
        planetTimer += Time.deltaTime;

        if (Obstacletimer > timeBetweenSpawns)
        {
            Obstacletimer = 0;
            int randNum = Random.Range(0, 3);
            Instantiate(obstacle, spawnPoints[randNum].transform.position, Quaternion.identity);
        }

          if (planetTimer > timeBetweenSpawnsPlanet)
        {
            planetTimer = 0;
            int randNum = Random.Range(0, 2);
            Instantiate(planet, spawnPointsP[randNum].transform.position, Quaternion.identity);
        }
    }
}
