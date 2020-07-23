using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHome : MonoBehaviour
{
    private int health; //易承的手手有10滴血
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 0){
            // 易承的手手爆炸
            ani.SetBool("die",true);
        }
    }

    public int getHp()
    {
        return health;
    }

    public void setHp(int health)
    {
        this.health = health;
    }
}
