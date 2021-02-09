using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyC : MonoBehaviour
{
    public void BuyC1()
    {

        if((SystemStorage.coin-1)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=1;
            SystemStorage.C1+=1;
        }
              
    }

    public void BuyC2()
    {

        if((SystemStorage.coin-2)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=2;
            SystemStorage.C2+=1;
        }
              
    }

    public void BuyC3()
    {

        if((SystemStorage.coin-3)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=3;
            SystemStorage.C3+=1;
        }
              
    }

    public void BuyC4()
    {

        if((SystemStorage.coin-4)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=4;
            SystemStorage.C4+=1;
        }
              
    }

    public void BuyC5()
    {

        if((SystemStorage.coin-5)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=5;
            SystemStorage.C5+=1;
        }
              
    }

    public void BuyC6()
    {

        if((SystemStorage.coin-6)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=6;
            SystemStorage.C6+=1;
        }
              
    }

    public void BuyC7()
    {

        if((SystemStorage.coin-7)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=7;
            SystemStorage.C7+=1;
        }
              
    }

    public void BuyC8()
    {

        if((SystemStorage.coin-8)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=8;
            SystemStorage.C8+=1;
        }
              
    }
}
