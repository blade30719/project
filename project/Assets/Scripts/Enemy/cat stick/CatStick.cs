using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStick : enemyParent
{

    
    private Rigidbody2D cs;
    private Animator ani;
    int speed ; //移動速度
    int hp;
    int str;
    GameObject enemyName;
    bool alive;
    int enemyHealth;

    public CatStick(string name , int health, int attack) : base("catStick" , 100 , 8)
    {
        setName(name);
        setHealth(health);
        setAttack(attack);
    }

    // Start is called before the first frame update
    void Start()
    {
        CatStick catStick = new CatStick("catStick", 100 , 8);
        cs = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        ani.SetBool("move",true);
        speed = 2;
        hp = catStick.getHealth();             //取得預設血量
        str = catStick.getAttack();            //取得預設攻擊
        alive = false;                         //判斷攻擊目標是否死亡
    }

    // Update is called once per frame
    void Update()
    {
        cs.velocity = Vector2.right * speed;
    }

    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "friendly" || collision.gameObject.name == "right")      //遇到敵人停下攻擊
        {
            speed = 0;
            ani.SetBool("move", false);
            ani.SetBool("attack", true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "friendly" || collision.gameObject.name == "right")
        {
            if (alive == false)                                                 //正在攻擊的敵人是否活著
            {
                alive = true;
                enemyName = collision.gameObject;                               //取得一個攻擊對象
                ani.SetBool("attack", true);                           //停止攻擊
                ani.SetBool("move", false);                              //恢復走路
            }
            speed = 0;
        }
    }

    void OnTriggerExit2D(Collider2D collision)                          //敵人消失繼續移動
    {
        if (collision.tag == "friendly" || collision.gameObject.name == "right")
        {
            alive = false;                                          //攻擊對象死亡
            speed = 2;
            ani.SetBool("attack", false);                           //停止攻擊
            ani.SetBool("move", true);                              //恢復走路    
        }
    }

    public void lossing_hp_catStick()                                              //扣血
    {
        if (alive == true)
        {
            enemyHealth = enemyName.GetComponent<RiceBall>().getHp();     //取得目前血量

            enemyHealth -= str;

            if (enemyHealth <= 0)                                 //血量低於0死亡
            {
                Debug.Log("die");
                Destroy(enemyName);                               //摧毀物件
            }

            enemyName.GetComponent<RiceBall>().setHp(enemyHealth);      //回傳血量
            Debug.Log(enemyName.GetComponent<RiceBall>().getHp());
        }
    }
    protected override bool death()
    {
        throw new System.NotImplementedException();
    }

    protected override bool fight()
    {
        throw new System.NotImplementedException();
    }

    protected override bool move()
    {
        throw new System.NotImplementedException();
    }

    public int getHp()
    {
        return hp;
    }

    public void setHp(int hp)
    {
        this.hp = hp;
    }
}
