using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class T1 : MonoBehaviour
{
    public GameObject ball;
    public GameObject canvas;//要移除的canvas
    public GameObject Pic1;
    private Image Image1;

    void Start()
    { 
        Image1 = Pic1.GetComponent<Image>();

        if(SystemStorage.T1==0){
            Image1.color = Color.gray;//灰
        }else{
            Image1.color = Color.white;//正常
        }
    }
    public void ClickT1()
    {
        if((SystemStorage.T1-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.T1-=1;
            if(SystemStorage.T1==0){
                Image1.color = Color.gray;//灰
            }
            Destroy (canvas);//刪掉canvas
            Destroy(GameObject.Find("毛球(Clone)"));
            Instantiate(ball, Vector2.zero, Quaternion.identity);//產生ball
            
        }   
    }
    
}
