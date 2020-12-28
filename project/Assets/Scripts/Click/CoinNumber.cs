using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinNumber : MonoBehaviour
{
    //public Text coinText;

 
    void Start()
    {

    }

    
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.coin.ToString();
    }

    public void Click() {
        SystemStorage.coin+=1;
    }

   
    public void Buy5(){
        if((SystemStorage.coin-5)<0)
        {
            Debug.Log("餘額不足");
        }else{
            SystemStorage.coin-=5;
        }
           
        
    }
}
