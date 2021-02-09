using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4 : MonoBehaviour
{
   public void ClickC4()
    {
        if((SystemStorage.C4-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.C4-=1;
        }   
    }
}
