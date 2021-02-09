using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F6 : MonoBehaviour
{
    public void ClickF6()
    {
        if((SystemStorage.F6-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.F6-=1;
        }   
    }
}