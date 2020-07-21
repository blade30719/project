using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackStore : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject canvas;//要移除的canvas
    void Start()
    {
        
    }
    
    public void OnClick()
    {	
        Destroy (canvas);//刪掉canvas
    }
}