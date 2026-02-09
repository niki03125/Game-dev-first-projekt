using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Transform ballSpawnPoint;

    public bool isHomeGoal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball") && scoreManager != null)
        {
            if(isHomeGoal)
                scoreManager.AddHomePoint();
            else
            scoreManager.AddAwayPoint();
            
            Debug.Log("Goal!!!!!!!!!");
            ResetBall(other.gameObject);
            
        }                       
    }

    void ResetBall(GameObject ball)
    {
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        ball.transform.position = ballSpawnPoint.position; // Reset
    }
}
