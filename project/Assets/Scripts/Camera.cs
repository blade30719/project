using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 MousePos;
    private float limitX, limitY;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MousePos = new Vector2(Input.mousePosition.x / Screen.width * 16, Input.mousePosition.y / Screen.height * 9);
        limitX = Mathf.Clamp(MousePos.x, -15.5f, 17.5f);
        limitY = Mathf.Clamp(MousePos.y, 0 + 0.5f, 9 - 0.5f);
        MousePos = new Vector3(limitX, transform.position.y,transform.position.z);
        transform.position = MousePos;
    }
}
