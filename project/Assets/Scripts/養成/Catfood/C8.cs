using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C8 : MonoBehaviour
{
    public void ClickC8()
    {
        if((SystemStorage.C8-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.C8-=1;
        }   
    }
}
