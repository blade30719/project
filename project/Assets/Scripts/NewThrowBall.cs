using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewThrowBall : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera follow; 
    [SerializeField] private GameObject ball;
    private Rigidbody BallRb;
    private Vector3 MousePos;
    private float limitX;
    private Vector3 startPos;
    private Vector3 endPos;
    private string direction;
    int countNum = 0;
    
    

    void Start()
    {
        BallRb = ball.GetComponent<Rigidbody>();
        ball.transform.position = new Vector3((float)-0.06, (float)0.96, -8);
    }

    // Update is called once per frame
    void Update()
    {
        //MousePos = new Vector2(Input.mousePosition.x / Screen.width * 16 , Input.mousePosition.y / Screen.height * 9);
        //transform.position = new Vector3(mousePos.x,mousePos.y,-1);

        if (Input.GetMouseButtonDown(0))
        {
            countNum++;
        }

        if (countNum == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                startPos = Input.mousePosition;
                //Debug.Log(startPos);
            }

            if (Input.GetMouseButtonUp(0))
            {
                endPos = Input.mousePosition;
                countNum++;
            }

            if(startPos.x > endPos.x)
            {
                direction = "left";
            }
            else
            {
                direction = "right";
            }

            MousePos = new Vector2(Input.mousePosition.x / Screen.width - 0.5f, Input.mousePosition.y / Screen.height * 9);
            limitX = Mathf.Clamp(transform.position.x + MousePos.x, -7.7f, 7.7f);
            MousePos = new Vector3(Input.mousePosition.x / Screen.width  /*limitX*/, Input.mousePosition.y / Screen.height /*transform.position.y*/, -8);
            MousePos.z = -5;
            transform.position = MousePos;
        }

        if(countNum == 2)
        {
            if (ball.transform.position.z < 0)
            {
                if (direction.Equals("left"))
                {
                    BallRb.useGravity = true;
                    //BallRb.velocity = new Vector3(0, 0, 3);
                    BallRb.AddForce(Vector3.left * 300 + Vector3.forward * 300);
                    countNum++;
                }
                else
                {
                    BallRb.useGravity = true;
                    //BallRb.velocity = new Vector3(0, 0, 3);
                    BallRb.AddForce(Vector3.right * 300 + Vector3.forward * 300);
                    countNum++;
                }
            }
            else
            {
                BallRb.velocity = new Vector3(0, 0, 0);
                BallRb.useGravity = false;
            }
        }
        if(countNum >= 3)
        {
            if (ball.transform.position.z >= 0)
            {
                BallRb.velocity = new Vector3(0, 0, 0);
                BallRb.useGravity = false;
            }
        }


    }

    /*
     private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 20), MousePos.ToString());
        GUI.Label(new Rect(10, 30, 300, 20), ball.transform.position.ToString());
    }
    */
}
