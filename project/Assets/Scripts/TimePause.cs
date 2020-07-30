using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePause : MonoBehaviour
{

    bool continueTime = false;                //宣告變數

    // Start is called before the first frame update
    void Start()
    {
        timeStop();
        continueTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (continueTime == true)               //判斷暫停或繼續
        {
            //Debug.Log("go");
            timeStart();
        }
        else
        {
            timeStop();
        }
    }

    public void timeStart()               //正常速度進行
    {
        Time.timeScale = 1;
    }

    public void timeStop()               //暫停
    {
        Time.timeScale = 0;
    }

    public void setTimeScale(bool input)             //暫停或開始的判斷
    {
        continueTime = input;
    }
}
