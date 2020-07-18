using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStick : enemyParent
{

    
    private Rigidbody2D cs;
    private Animator ani;
    int speed ; //移動速度
    int hp;
    
    public CatStick(string name , int health) : base("catStick" , 100)
    {
        setName(name);
        setHealth(health);
    }

    // Start is called before the first frame update
    void Start()
    {
        CatStick catStick = new CatStick("catStick", 100);
        cs = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        ani.SetBool("move",true);
        speed = 2;
        hp = catStick.getHealth();
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
            speed = 0;
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
