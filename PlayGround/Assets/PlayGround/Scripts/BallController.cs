using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // declare variables
    public int forwardForce;
    Rigidbody BallRigidbody;

    private void Awake()
    {
        BallRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        TestStartFunction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TestStartFunction()
    {

        BallRigidbody.AddForce(transform.forward * -100);
        BallRigidbody.AddForce(transform.right * -100); // I think it would be fun to do this everytime the ball hits a wall since the ball will rotate around.
    }

    void AddForwardForce()
    {
        
        BallRigidbody.AddForce(transform.forward * forwardForce * Random.Range(-1f, 1f)); //maybe give the player the ability to change forward force to have some control over the ball to get it to a goal
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ball entered collision. Gameobject Tag: " + collision.gameObject.tag);
        if(collision.gameObject.tag == "Environment")
        {
            AddForwardForce();
            Debug.Log("forward Force Added");
        }
    }
}
