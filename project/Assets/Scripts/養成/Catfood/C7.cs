using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C7 : MonoBehaviour
{
    public void ClickC7()
    {
        if((SystemStorage.C7-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.C7-=1;
        }   
    }
}
