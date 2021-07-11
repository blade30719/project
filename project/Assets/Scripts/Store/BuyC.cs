using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyC : MonoBehaviour
{
    public void BuyC1()
    {

        if((SystemStorage.coin-5)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=5;
            SystemStorage.C1+=1;
        }
              
    }

    public void BuyC2()
    {

        if((SystemStorage.coin-5)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=5;
            SystemStorage.C2+=1;
        }
              
    }

    public void BuyC3()
    {

        if((SystemStorage.coin-10)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=10;
            SystemStorage.C3+=1;
        }
              
    }

    public void BuyC4()
    {

        if((SystemStorage.coin-10)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=10;
            SystemStorage.C4+=1;
        }
              
    }

    public void BuyC5()
    {

        if((SystemStorage.coin-15)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=15;
            SystemStorage.C5+=1;
        }
              
    }

    public void BuyC6()
    {

        if((SystemStorage.coin-15)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=15;
            SystemStorage.C6+=1;
        }
              
    }

    public void BuyC7()
    {

        if((SystemStorage.coin-20)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=20;
            SystemStorage.C7+=1;
        }
              
    }

    public void BuyC8()
    {

        if((SystemStorage.coin-20)<0){
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=20;
            SystemStorage.C8+=1;
        }
              
    }
}
