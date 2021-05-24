using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewThrowBall : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera follow; 
    [SerializeField] private GameObject ball;
    private Vector3 MousePos;
    private float limitX;
    private Vector3 startPos;
    private Vector3 endPos;
    int countNum = 0;
    
    

    void Start()
    {
        
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
                Debug.Log(startPos);
            }

            if (Input.GetMouseButtonUp(0))
            {
                endPos = Input.mousePosition;
            }

            MousePos = new Vector2(Input.mousePosition.x / Screen.width - 0.5f, Input.mousePosition.y / Screen.height * 9);
            limitX = Mathf.Clamp(transform.position.x + MousePos.x, -7.7f, 7.7f);
            MousePos = new Vector3(limitX, transform.position.y, transform.position.z);
            MousePos.z = -2;
            transform.position = MousePos;
        }


    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 20), MousePos.ToString());
        GUI.Label(new Rect(10, 30, 300, 20), ball.transform.position.ToString());
    }
}
