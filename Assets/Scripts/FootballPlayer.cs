using UnityEngine;

public class FootballPlayer : MonoBehaviour
{
    private Rigidbody rigidbody;
    [SerializeField] private float force = 5000f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(Vector3.forward* force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(Vector3.back * force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(Vector3.right * force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(Vector3.left * force * Time.deltaTime);
        }
        
    }
}
