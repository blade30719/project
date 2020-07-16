using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStick : enemyParent
{

    float summonTime = 2.0f;
    private Rigidbody2D cs;
    private Animator ani;
    int speed = 2; //移動速度
    [SerializeField] private GameObject catStick;
    [SerializeField] private Transform Enemy_Position;
    

    public CatStick(string name , int heath) : base("catStick" , 2)
    {
        setName("catStick");
        setHealth(2);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 2.0f); // 重複呼叫SpawnEnemy function()、0延遲開場就做、每summonTime秒呼叫
    }

    // Update is called once per frame
    void Update()
    {
        cs.velocity = Vector2.right * speed;
    }

    void SpawnEnemy(){
        //主堡沒爆
        //if(){
            Vector3 pos = new Vector3(-19,-7,-1); //宣告位置pos，Random.Range
            Instantiate(catStick,Enemy_Position.position,Enemy_Position.rotation);
       // }
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
