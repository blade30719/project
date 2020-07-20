using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CatfoodStore : MonoBehaviour
{
	
    public GameObject canvasPrefab;//要產生的canvas
    
    void Start()
    {

    }
    
    public void OnClick()
    {
		Debug.Log("press");
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);//跑出canvasPrefab
    }
}
