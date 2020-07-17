using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStick : enemyParent
{

    
    private Rigidbody2D cs;
    private Animator ani;
    int speed ; //移動速度
    int hp;
    
    public CatStick(string name , int heath) : base("catStick" , 2)
    {
        setName("catStick");
        setHealth(2);
    }

    // Start is called before the first frame update
    void Start()
    {
        cs = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        ani.SetBool("move",true);
        speed = 2;
        hp = 100;
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
            //Debug.Log("speed == 0");
            speed = 0;
            ani.SetBool("move", false);
            ani.SetBool("attack", true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "friendly" || collision.gameObject.name == "right")
        {
            //Debug.Log("speed != 0");
            speed = 0;
            //int heath = collision.GetComponent<RiceBall>().GetHp();
            //Debug.Log(heath);
        }
    }

    void OnTriggerExit2D(Collider2D collision)                          //敵人消失繼續移動
    {
        if (collision.tag == "friendly" || collision.gameObject.name == "right")
        {
            //Debug.Log("speed != 0");
            speed = 2;
            ani.SetBool("attack", false);
            ani.SetBool("move", true);
        }
    }

    public void lossing_hp_catStick(int hurt)                                              //扣血
    {
        do
        {
            this.hp -= hurt;
            if (hp <= 0)
            {
                Debug.Log("die");
                Destroy(this.gameObject);
            }
            //Debug.Log(hp);
        } while (false);
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

    public int getHealth()
    {
        return hp;
    }

    public void setHealth(int hp)
    {
        this.hp = hp;
    }
}
