using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 MousePos , mousePos;
    private float limitX, limitY;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0)) {
            mousePos = new Vector2(Input.mousePosition.x / Screen.width - 0.5f, Input.mousePosition.y / Screen.height * 72);     //滑鼠位置

            MousePos = new Vector2(Input.mousePosition.x / Screen.width - 0.5f, Input.mousePosition.y / Screen.height * 72);     //滑鼠位置
            limitX = Mathf.Clamp(transform.position.x + MousePos.x, -15.5f, 17.5f);                       //X軸範圍 *
                                                                                                          //limitY = Mathf.Clamp(MousePos.y, 0 + 0.5f, 9 - 0.5f);                  //Y軸範圍

            MousePos = new Vector3(limitX, transform.position.y, transform.position.z);
            if (mousePos.y >= 15.0)
                transform.position = MousePos;
        }
        /*
        mousePos = new Vector2(Input.mousePosition.x / Screen.width -0.5f, Input.mousePosition.y / Screen.height * 72);     //滑鼠位置

        MousePos = new Vector2(Input.mousePosition.x / Screen.width -0.5f, Input.mousePosition.y / Screen.height * 72);     //滑鼠位置
        limitX = Mathf.Clamp(transform.position.x + MousePos.x, -15.5f, 17.5f);                       //X軸範圍 *
        //limitY = Mathf.Clamp(MousePos.y, 0 + 0.5f, 9 - 0.5f);                  //Y軸範圍
        
        MousePos = new Vector3(limitX, transform.position.y,transform.position.z);
        if(mousePos.y >= 15.0)
            transform.position = MousePos;                                         //更新位置
        */
    }

    internal Vector3 ScreenToWorldPosition(Vector3 mousePosition)
    {
        throw new NotImplementedException();
    }

    /*private void OnGUI()
    {
        GUI.Label(new Rect(10, 30, 300, 20), Input.mousePosition.ToString());
        GUI.Label(new Rect(10, 10, 300, 20), mousePos.ToString());
    }*/
}
