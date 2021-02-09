using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C3 : MonoBehaviour
{
    public void ClickC3()
    {
        if((SystemStorage.C3-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.C3-=1;
        }   
    }
}
