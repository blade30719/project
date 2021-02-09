using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyF : MonoBehaviour
{
    public void BuyF1()
    {

        if((SystemStorage.coin-5)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=5;
            SystemStorage.F1+=1;
        }
              
    }

    public void BuyF2()
    {

        if((SystemStorage.coin-5)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=5;
            SystemStorage.F2+=1;
        }
              
    }

    public void BuyF3()
    {

        if((SystemStorage.coin-10)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=10;
            SystemStorage.F3+=1;
        }
              
    }

    public void BuyF4()
    {

        if((SystemStorage.coin-10)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=10;
            SystemStorage.F4+=1;
        }
              
    }

    public void BuyF5()
    {

        if((SystemStorage.coin-15)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=15;
            SystemStorage.F5+=1;
        }
              
    }

    public void BuyF6()
    {

        if((SystemStorage.coin-15)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=15;
            SystemStorage.F6+=1;
        }
              
    }

    public void BuyF7()
    {

        if((SystemStorage.coin-20)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=20;
            SystemStorage.F7+=1;
        }
              
    }

    public void BuyF8()
    {

        if((SystemStorage.coin-20)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=20;
            SystemStorage.F8+=1;
        }
              
    }
}
