using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public void Buy5()
    {

        if((SystemStorage.coin-5)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=5;
        }
              
    }

    public void Buy10()
    {

        if((SystemStorage.coin-10)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=10;
        }
              
    }

    public void Buy15()
    {

        if((SystemStorage.coin-15)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=15;
        }
              
    }

    public void Buy20()
    {

        if((SystemStorage.coin-20)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=20;
        }
              
    }
}
