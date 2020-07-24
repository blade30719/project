using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameObject button;//要產生的button
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-0.1f, 0, 0);
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(+0.1f,0, 0);
        }

    
    /*void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.name == "Catfood store"){
            Instantiate (button, Vector2.zero, Quaternion.identity);//產生button
        }   
    }*/
    }
}
