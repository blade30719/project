using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
//貓奴移動
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MoveLeft(){
        gameObject.transform.position += new Vector3(-0.05f,0, 0);
    }
    public void MoveRight(){
        gameObject.transform.position += new Vector3(+0.05f,0, 0);
    }
}
