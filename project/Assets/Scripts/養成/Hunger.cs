using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{
    // Start is called before the first frame update

    /*
     
    屬性:

    1. 生命值
    2. 飢餓度
    3. 活力值
    4. 水分
    5. 健康度


    異常狀態:

    1. 生病
    2. 憂鬱
    3. 渴
    4. 受傷

    */
    

    int MP = 9999;
    [SerializeField] Slider hunger;
    

    void Start()
    { 
        InvokeRepeating("minusMP",10.0f, 10.0f);//10sec first , 10sec forever
    }

    // Update is called once per frame
    void Update()
    { 
        hunger.value = MP;
    }

    public void minusMP()
    {
        MP -= 99;
        //Debug.LogWarning("餓了阿");
    }

   
}
