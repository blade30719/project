using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackStore : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickEvent()
    {
        Destroy (canvas);//刪掉canvas
    }
}
