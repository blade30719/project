using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class C1 : MonoBehaviour
{
    public void ClickC1()
    {
        if((SystemStorage.C1-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.C1-=1;
        }   
    }
}
