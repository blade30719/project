using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C6 : MonoBehaviour
{
    public void ClickC6()
    {
        if((SystemStorage.C6-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.C6-=1;
        }   
    }
}
