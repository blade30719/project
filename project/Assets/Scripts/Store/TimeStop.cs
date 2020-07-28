using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStop : MonoBehaviour
{
    void Update(){
        void OnEnable()
        {
            Time.timeScale = 0f;//時間暫停
        }
    
        void OnDisable()
        {
           Time.timeScale = 1f;//時間以正常速度運行
        }
    }
}
