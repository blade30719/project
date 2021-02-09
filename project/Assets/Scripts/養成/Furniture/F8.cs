using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F8 : MonoBehaviour
{
    public void ClickF8()
    {
        if((SystemStorage.F8-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.F8-=1;
        }   
    }
}