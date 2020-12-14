using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoleAttributes : MonoBehaviour
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

    int HP = 999999;
    int countS = 0;
    [SerializeField] Slider HealthBar;

    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        sick();
        HealthBar.value = HP;
    }

    public void sick()
    {
        if (Input.GetKeyDown("s"))
        {
            countS++;
        }

        if(countS % 2 != 0)
        {
            HP -= 10;
            //countS++;
        }
    }
}
