using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//敵人方的父類別:enemyName、health
public abstract class enemyParent : MonoBehaviour
{
 
	private string enemyName;  //敵人名
	private int health = 0;    //敵人的血量
    private int attack = 0;    //攻擊力

    public enemyParent(string name, int health, int attack)
    {
	    this.enemyName = name;
        this.health = health;
        this.attack = attack;
    }
    
    //子類別呼叫取得敵人名
    protected string getName(){
        return enemyName;
    }
    
    //子類別呼叫取得血量
    protected int getHealth(){
        return health;
    }
    public int getAttack()
    {
        return attack;
    }

    public void setAttack(int str)
    {
        this.attack = str;
    }

    //設定敵人名
    protected void setName(string name){
        this.enemyName = name;
    }
    
    //設定血量
    protected void setHealth(int hp){
        this.health = hp;
    }
	
  
}
