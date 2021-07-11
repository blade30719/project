﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F6 : MonoBehaviour
{
    public GameObject Pic1;
    private Image Image1;
    void Start()
    { 
        Image1 = Pic1.GetComponent<Image>();

        if(SystemStorage.F6==0){
            Image1.color = Color.gray;//灰
        }else{
            Image1.color = Color.white;//正常
        }
    }
    public void ClickF6()
    {
        if((SystemStorage.F6-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.F6-=1;
            if(SystemStorage.F6==0){
                Image1.color = Color.gray;//灰
            }
        }   
    }
}