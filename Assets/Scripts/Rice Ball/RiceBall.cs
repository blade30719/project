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

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        ani.SetBool("walk",true);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.left * 2;  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "enemy")
        {
            ani.SetBool("walk", false);
            ani.SetBool("attack",true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            ani.SetBool("attack", false);
            ani.SetBool("walk", true);
        }
    }
}
