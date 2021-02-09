using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F4 : MonoBehaviour
{
    public void ClickF4()
    {
        if((SystemStorage.F4-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.F4-=1;
        }   
    }
}