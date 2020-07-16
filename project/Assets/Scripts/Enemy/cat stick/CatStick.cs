using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStick : enemyParent
{

    
    private Rigidbody2D cs;
    private Animator ani;
    int speed ; //移動速度
    
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
        ani.SetBool("walk",true);
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        cs.velocity = Vector2.right * speed;
    }

    

    void OnTriggerEnter2D()
    {

    }

    void OnTriggerExit2D()
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

}
