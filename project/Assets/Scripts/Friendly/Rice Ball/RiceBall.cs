using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiceBall : friendlyParent
{
    public RiceBall(string name , int health , int attack) : base("riceBall" , 100 , 10)
    {
        setName(name);
        setHealth(health);
        setAttack(attack);
    }

    public override bool death()
    {
        throw new System.NotImplementedException();
    }

    public override bool fight()
    {
        throw new System.NotImplementedException();
    }

    public override bool move()
    {
        throw new System.NotImplementedException();
    }

    private Rigidbody2D rb;
    private Animator ani;
    int speed;
    int hp;
    int str;
    GameObject enemyName;
    bool alive;
    int enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        RiceBall riceBall = new RiceBall("riceBall", 100 , 10);             //宣告物件
        rb = GetComponent<Rigidbody2D>();      //取得角色身上component
        ani = GetComponent<Animator>();        //取得角色身上component
        ani.SetBool("walk",true);              //走路動畫
        speed = 2;                             //移動速度
        hp = riceBall.getHealth();             //取得預設血量
        str = riceBall.getAttack();            //取得預設攻擊
        alive = false;                         //判斷攻擊目標是否死亡
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.left * speed;    //移動
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy" || collision.gameObject.name == "left")      //遇到敵人停下攻擊
        {
            speed = 0;
            ani.SetBool("walk", false);                   //遇到敵人停止走路動畫
            ani.SetBool("attack",true);                   //遇到敵人開始攻擊動畫
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.name == "left")
        {
            if (alive == false)                                                 //正在攻擊的敵人是否活著
            {
                alive = true;                                                   
                enemyName = collision.gameObject;                               //取得一個攻擊對象
                enemyHealth = collision.GetComponent<CatStick>().getHp();       //取得對方血量
            }
            else
            {
                enemyName.GetComponent<CatStick>().setHp(enemyHealth);          //攻擊後回傳對方剩餘血量
                //Debug.Log(collision.GetComponent<CatStick>().getHp());
            }
            speed = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)                            //敵人消失繼續移動
    {
        //Debug.Log("speed != 0");
        if (collision.gameObject.tag == "enemy" || collision.gameObject.name == "left")
        {
            speed = 2;
            ani.SetBool("attack", false);                           //停止攻擊
            ani.SetBool("walk", true);                              //恢復走路
            alive = false;                                          //攻擊對象死亡
        }
    }


    public void lossing_hp()                                  //扣血
    {
        enemyHealth -= str;

        if (enemyHealth <= 0)                                 //血量低於0死亡
        {
            Debug.Log("die");
            Destroy(enemyName);                               //摧毀物件
        }
    }

    public void setHp(int hp)                                 //設定我方血量
    {
        this.hp = hp;
        //Debug.Log(this.hp);
    }

    public int getHp()                                        //取得我方血量
    {
        return hp;
    }
}
