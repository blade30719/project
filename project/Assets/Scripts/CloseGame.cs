using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    //DateTime startTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    } 
    public void OnApplicationPause(bool paused) {
        if(paused) {
            Debug.Log("Paused");
            //StartTime = DateTime.Now;
        }
        else
        {
            Debug.Log("resumed");
            /*DateTime curtimer = DateTime.Now;
            int timer = GetSubSeconds(StartTime, curtimer);//間格秒數*/
        }
    }

    /*public int GetSubMinutes(DateTime startTimer, DateTime endTimer)
    {
        TimeSpan startSpan = new TimeSpan(startTimer.Ticks);

        TimeSpan nowSpan = new TimeSpan(endTimer.Ticks);

        TimeSpan subTimer = nowSpan.Subtract(startSpan).Duration();
        
        return (int)subTimer.TotalMinutes;
    }*/

}
