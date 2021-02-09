using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F2 : MonoBehaviour
{
    public void ClickF2()
    {
        if((SystemStorage.F2-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.F2-=1;
        }   
    }
}