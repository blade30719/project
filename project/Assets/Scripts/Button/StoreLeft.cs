using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreLeft : MonoBehaviour
{
    private bool IsStart = false;
    private float LastTime = 0;
    private bool GoLeft = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GoLeft == true)
        {
            FindObjectOfType<Cat>().MoveLeft(); 
        }
    }
    public void LongPress(bool bStart)//長按
    {
        IsStart = bStart;
        if (IsStart)
        {
            LastTime = Time.time;
            GoLeft = true;
        }
        else if (LastTime != 0)
        {
            LastTime = 0;
            GoLeft = false;
        }
    }
}

