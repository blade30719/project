using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C5 : MonoBehaviour
{
    public void ClickC5()
    {
        if((SystemStorage.C5-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.C5-=1;
        }   
    }
}
