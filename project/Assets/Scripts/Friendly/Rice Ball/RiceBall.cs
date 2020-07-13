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

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        ani.SetBool("walk",true);
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(speed);
        rb.velocity = Vector2.left * speed;  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("speed == 0");
        if (collision.tag == "enemy" || collision.gameObject.name == "left")
        {
            Debug.Log("speed == 0");
            speed = 0;
            ani.SetBool("walk", false);
            ani.SetBool("attack",true);
            StartCoroutine(waitTime(1));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("speed != 0");
        if (collision.gameObject.tag == "enemy" || collision.gameObject.name == "left")
        {
            Debug.Log("speed != 0");
            speed = 2;
            ani.SetBool("attack", false);
            ani.SetBool("walk", true);
        }
    }

    IEnumerator waitTime(int time)
    {
        yield return new WaitForSeconds(time);
    }
}
