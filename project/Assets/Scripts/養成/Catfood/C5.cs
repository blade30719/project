using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class C5 : MonoBehaviour
{
    public GameObject Pic1;
    private Image Image1;
    void Start()
    { 
        Image1 = Pic1.GetComponent<Image>();

        if(SystemStorage.C5==0){
            Image1.color = Color.gray;//灰
        }else{
            Image1.color = Color.white;//正常
        }
    }
    public void ClickC5()
    {
        if((SystemStorage.C5-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.C5-=1;
            if(SystemStorage.C5==0){
                Image1.color = Color.gray;//灰
            }
        }   
    }
}
