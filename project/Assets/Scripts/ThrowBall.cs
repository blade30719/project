using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    private float position ;
    public Rigidbody BallRb;

    void Start()
    {
        BallRb = GetComponent<Rigidbody>();
        position = ball.transform.position.z;
        Debug.Log(position);
    }

    // Update is called once per frame
    void Update()
    {
        position = ball.transform.position.z;
        if (position < 0)
        {
            BallRb.velocity = new Vector3(0,0,2);
            BallRb.transform.Rotate(0,0,(float)0.5);
        }
        else
        {
            BallRb.velocity = new Vector3(0, 0, 0);
            BallRb.useGravity = false;
        }
    }
}
