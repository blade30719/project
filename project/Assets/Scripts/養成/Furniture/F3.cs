using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F3 : MonoBehaviour
{
    public void BuyF3()
    {
        if((SystemStorage.F3-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.F3-=1;
        }   
    }
}