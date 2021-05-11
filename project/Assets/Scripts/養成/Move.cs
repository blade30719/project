using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public int index = 0;                 //初始位置
    public float speed = 0.05f;           //移動速度
    public Transform[] Target;            //移動目標
    public GameObject ball = GameObject.Find("毛球(Clone)");
    
    void Update()
    {
       
        if (transform.position != Target[index].position)//未達到指定的index位置，調用Move函數繼續移動
        {
            Cicle();  
        }
        
        else//到了index位置,改變index值，不斷循環
        {
            index = ++index % Target.Length;
        }
    }
    void Cicle()
    {
        //從當前位置按照指定速度移到index位置
        Vector2 temp = Vector2.MoveTowards(transform.position, Target[index].position, speed * Time.deltaTime);
        
        GetComponent<Rigidbody2D>().MovePosition(temp);//無視物體
    
    }

    public void moveToBall()
    {
        Vector2 temp = Vector2.MoveTowards(transform.position, ball.GetComponent<ThrowBall>().getBallPosition(), speed * Time.deltaTime);
    }
}
