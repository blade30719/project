using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimePause : MonoBehaviour
{

    bool continueTime = false;                //宣告變數
    int timer;                                //計時器
    [SerializeField] private TextMeshProUGUI test;

    // Start is called before the first frame update
    void Start()
    {
        timeStop();
        continueTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer = Mathf.FloorToInt(Time.time);              //更新遊戲時間
        int min = timer / 60;
        int secend = timer % 60;
        test.text = min.ToString() + " : " + secend.ToString();                     //轉傳成字串輸出到TMP
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
