using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C2 : MonoBehaviour
{
    public void ClickC2()
    {
        if((SystemStorage.C2-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.C2-=1;
        }   
    }
}
