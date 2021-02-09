using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F7 : MonoBehaviour
{
    public void ClickF7()
    {
        if((SystemStorage.F7-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.F7-=1;
        }   
    }
}