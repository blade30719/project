using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatfoodStore : MonoBehaviour
{
 
    public GameObject canvasPrefab;//要產生的canvas
    
    void Start()
    {
	
    }
    
    public void OnClick()
    {
		
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);//生產canvasPrefab
    }
}