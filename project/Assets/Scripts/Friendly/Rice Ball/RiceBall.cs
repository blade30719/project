using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiceBall : friendlyParent
{
    public RiceBall(string name , int heath) : base("Rice_ball" , 10)
    {

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

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();      //取得角色身上component
        ani = GetComponent<Animator>();
        ani.SetBool("walk",true);              //起始移動
        speed = 2;                             //移動速度
        hp = 100;                              //血量
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(speed);
        rb.velocity = Vector2.left * speed;    //移動
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("speed == 0");
        if (collision.tag == "enemy" || collision.gameObject.name == "left")      //遇到敵人停下攻擊
        {
            //Debug.Log("speed == 0");
            speed = 0;
            ani.SetBool("walk", false);
            ani.SetBool("attack",true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.name == "left")
        {
            //Debug.Log("speed != 0");
            speed = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)                            //敵人消失繼續移動
    {
        //Debug.Log("speed != 0");
        if (collision.gameObject.tag == "enemy" || collision.gameObject.name == "left")
        {
            //Debug.Log("speed != 0");
            speed = 2;
            ani.SetBool("attack", false);
            ani.SetBool("walk", true);
        }
    }


    public void lossing_hp(int hurt)                                              //扣血
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

    public int GetHp()
    {
        return hp;
    }

    public void SetHp(int hp)
    {
        this.hp = hp;
        Debug.Log(this.hp);
    }
}
