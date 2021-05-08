using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewThrowBall : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera follow; 
    [SerializeField] private GameObject ball;
    private Vector2 mousePos;
    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mousePos = new Vector2(Input.mousePosition.x / Screen.width * 16 , Input.mousePosition.y / Screen.height * 9);
        //transform.position = new Vector3(mousePos.x,mousePos.y,-1);
        Vector3 mouseWorldPosition = follow.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = -2;
        transform.position = mouseWorldPosition;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 20), mousePos.ToString());
        GUI.Label(new Rect(10, 30, 300, 20), ball.transform.position.ToString());
    }
}
