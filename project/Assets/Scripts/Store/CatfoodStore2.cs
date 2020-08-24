using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatfoodStore2 : MonoBehaviour
{
    public GameObject button;//要產生的button
    void Start()
    {
	
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Instantiate (button, Vector2.zero, Quaternion.identity);//產生button
    }
    
    void OnTriggerExit2D(Collider2D col)//離開銷毀按鈕
    {
        Destroy(GameObject.Find("StoreButton2(Clone)"));
        
    }
}