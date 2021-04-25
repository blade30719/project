using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyT : MonoBehaviour
{
    public void BuyT1()
    {

        if((SystemStorage.coin-5)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=5;
            SystemStorage.T1+=1;
        }
              
    }

    public void BuyT2()
    {

        if((SystemStorage.coin-5)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=5;
            SystemStorage.T2+=1;
        }
              
    }

    public void BuyT3()
    {

        if((SystemStorage.coin-10)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=10;
            SystemStorage.T3+=1;
        }
              
    }

    public void BuyT4()
    {

        if((SystemStorage.coin-10)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=10;
            SystemStorage.T4+=1;
        }
              
    }

    public void BuyT5()
    {

        if((SystemStorage.coin-15)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=15;
            SystemStorage.T5+=1;
        }
              
    }

    public void BuyT6()
    {

        if((SystemStorage.coin-15)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=15;
            SystemStorage.T6+=1;
        }
              
    }

    public void BuyT7()
    {

        if((SystemStorage.coin-20)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=20;
            SystemStorage.T7+=1;
        }
              
    }

    public void BuyT8()
    {

        if((SystemStorage.coin-20)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=20;
            SystemStorage.T8+=1;
        }
              
    }
}
