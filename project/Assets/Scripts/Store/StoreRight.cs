using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreRight : MonoBehaviour
{
    private bool IsStart = false;
    private float LastTime = 0;
    private bool GoRight = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GoRight == true)
        {
            FindObjectOfType<Cat>().MoveRight(); 
        }
    }
    public void LongPress(bool bStart)//長按
    {
        IsStart = bStart;
        if (IsStart)
        {
            LastTime = Time.time;
            GoRight = true;
        }
        else if (LastTime != 0)
        {
            LastTime = 0;
            GoRight = false;
        }
    }
}

