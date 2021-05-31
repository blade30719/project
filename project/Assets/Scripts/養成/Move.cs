using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public int index = 0;                                     //初始位置
    public float speed = 0.05f;                               //移動速度
    public Transform[] Target = new Transform[12];            //移動目標
    public ArrayList[] Target1 = new ArrayList[6];
    //public GameObject ball = GameObject.Find("毛球(Clone)");
    public GameObject gb;
    int ballPos = 0;
    Transform temp ;

    void Start()
    {
        temp = Target[0];
    }

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
        // Vector2 temp = Vector2.MoveTowards(transform.position, ball.GetComponent<ThrowBall>().getBallPosition(), speed * Time.deltaTime);
        //gb = ball.GetComponent<ThrowBall>().getBall();
        
    }

    public void setgb()
    {
        gb = GameObject.Find("毛球(Clone)");
        Target[ballPos] = temp;

        if (index < 11)
        {
            ballPos = index + 1;
            temp = Target[ballPos];
            Target[index + 1] = gb.transform;
        }
        else
        {
            ballPos = 11;
            temp = Target[0];
            Target[0] = gb.transform;
        }
        //Target[3] = gb.transform;
        //Target[5] = gb.transform;
        //Target[7] = gb.transform;
        //Target[9] = gb.transform;
        //Target[11] = gb.transform;
    }
}
