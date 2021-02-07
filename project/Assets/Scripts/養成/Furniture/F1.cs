using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F1 : MonoBehaviour
{
    public void BuyF1()
    {
        if((SystemStorage.F1-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.F1-=1;
        }   
    }
}