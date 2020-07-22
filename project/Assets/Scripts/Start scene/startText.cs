using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class startText : MonoBehaviour
{
    public Text mytext;
    
    void Start()
    {
        //InokeRepeating 重複呼叫
        InvokeRepeating("getText", 0.5f , 1f);//0.5秒後，每1秒重複呼叫函式getText
    }

   
    void getText()
    {
        if (mytext.text == ""){//如果是空的

            mytext.text = "點擊螢幕任意處進行遊戲"; //顯示此文字

        }else{

            mytext.text = "";//變回空的    
        }
    }
}
