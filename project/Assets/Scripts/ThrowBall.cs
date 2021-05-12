using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    private float position ;
    public Rigidbody BallRb;
    int touchcount;

    void Start()
    {
        touchcount = 0;
        BallRb = GetComponent<Rigidbody>();
        position = ball.transform.position.z;
        Debug.Log(position);
        ball.transform.position = new Vector3((float)-0.06, (float)0.96, -8);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchcount++;
            Debug.Log(touchcount);
        }
        if(touchcount >= 1)
        {
            position = ball.transform.position.z;
            if (position < 0)
            {
                Debug.Log(touchcount);
                BallRb.useGravity = true;
                BallRb.velocity = new Vector3(0, 0, 3);
                //BallRb.AddForce(transform.up  * 3 + transform.forward * 3);
                //BallRb.transform.Rotate(0,0,(float)0.5);
            }
            else
            {
                BallRb.velocity = new Vector3(0, 0, 0);
                BallRb.useGravity = false;
                GameObject.Find("小貓走路").GetComponent<Move>().moveToBall();
            }
            
        }
    }

    public Vector3 getBallPosition()
    {
        return ball.transform.position;
    }
}
