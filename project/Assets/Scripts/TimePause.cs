using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePause : MonoBehaviour
{

    bool continueTime = false;

    // Start is called before the first frame update
    void Start()
    {
        timeStop();
        continueTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (continueTime == true)
        {
            //Debug.Log("go");
            timeStart();
        }
        else
        {
            timeStop();
        }
    }

    public void timeStart()
    {
        Time.timeScale = 1;
    }

    public void timeStop()
    {
        Time.timeScale = 0;
    }

    public void setTimeScale(bool input)
    {
        continueTime = input;
    }
}
