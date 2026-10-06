using UnityEngine;

public class CompanionBallScript : MonoBehaviour
{
    public static CompanionBallScript instance;
    private Transform startSpawnPoint;
    private Transform ballSpawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startSpawnPoint = new GameObject().transform;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < PlayerController.instance.deathHeight) Respawn();
    }
    public void SetSpawnPoint(Transform aPoint)
    {
        ballSpawnPoint = aPoint;
    }
    public void Respawn()
    {
        
        if (ballSpawnPoint != null)
        {
            transform.position = ballSpawnPoint.position;
        }
        else if (startSpawnPoint != null)
        {
            transform.position = startSpawnPoint.position;
        }
    }
}
