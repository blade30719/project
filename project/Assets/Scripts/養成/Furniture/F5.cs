using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F5 : MonoBehaviour
{
    public void ClickF5()
    {
        if((SystemStorage.F5-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.F5-=1;
        }   
    }
}