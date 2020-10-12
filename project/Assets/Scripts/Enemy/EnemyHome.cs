using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHome : MonoBehaviour
{
    private int health; //易承的手手有10滴血
    Animator ani;
    [SerializeField] private GameObject blackBG;
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject camera;
    [SerializeField] private GameObject end;
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

    public int getHp()         //回傳血量
    {
        return health;
    }

    public void setHp(int health)          //設定血量
    {
        this.health = health;
    }

    public void ending()                //結束畫面
    {
        camera.GetComponent<TimePause>().setTimeScale(false);
        blackBG.SetActive(true);
        button.SetActive(false);
        end.SetActive(true);

    }
}
