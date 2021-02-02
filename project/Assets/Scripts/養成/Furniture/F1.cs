using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F1 : MonoBehaviour
{
    //bool isUpdateEnable = False;

    void Start()
    {

    }

    
    void Update()
    {

        //if(bool isUpdateEnable){
        //   Debug.Log(" ");
        //}else{
            GetComponent<Text>().text=SystemStorage.F1.ToString();
        //}

    }
    public void Yes()
    {
       bool isUpdateEnable = true; 
       Debug.Log(" ");
    }
    public void Click() 
    {
        SystemStorage.F1+=1;
    }

    public void BuyF1()
    {

        if((SystemStorage.F1-1)<0){
            Debug.Log("庫存不足");
        }else{
            SystemStorage.F1-=1;
        }   

    }
}