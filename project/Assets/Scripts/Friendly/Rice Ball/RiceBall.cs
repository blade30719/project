using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiceBall : friendlyParent
{
    public RiceBall(string name , int health) : base("riceBall" , 10)
    {
        setName(name);
        setHealth(health);
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
    GameObject enemyName;
    bool alive;
    int enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        RiceBall riceball = new RiceBall("riceBall", 100);
        rb = GetComponent<Rigidbody2D>();      //取得角色身上component
        ani = GetComponent<Animator>();
        ani.SetBool("walk",true);              //起始移動
        speed = 2;                             //移動速度
        hp = riceball.getHealth();
        alive = false;
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
            ani.SetBool("walk", false);
            ani.SetBool("attack",true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.name == "left")
        {
            if (alive == false)
            {
                Debug.Log("get name");
                alive = true;
                enemyName = collision.gameObject;
                enemyHealth = collision.GetComponent<CatStick>().getHp();
            }
            if(alive == true)
            {
                enemyName.GetComponent<CatStick>().setHp(enemyHealth);
                Debug.Log(collision.GetComponent<CatStick>().getHp());
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
            ani.SetBool("attack", false);
            ani.SetBool("walk", true);
            alive = false;
        }
    }


    public void lossing_hp(int hurt)                                              //扣血
    {
        enemyHealth -= 10;

        if (enemyHealth <= 0)
        {
            Debug.Log("die");
            Destroy(enemyName);
        }
    }

    public void setHp(int hp)
    {
        this.hp = hp;
        Debug.Log(this.hp);
    }

    public int getHp()
    {
        return hp;
    }
}
