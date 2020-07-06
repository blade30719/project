using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//敵人方的父類別:enemyName、health
public abstract class enemyParent : MonoBehaviour
{
 
	private string enemyName;  //敵人名
	private int health = 0;    //敵人的血量
	
	public enemyParent(string name, int health){
	    this.enemyName = name;
        this.health = health;
	}
    
    //子類別呼叫取得敵人名
    protected string getName(){
        return enemyName;
    }
    
    //子類別呼叫取得血量
    protected int getHealth(){
        return health;
    }
    
    //設定敵人名
    protected void setName(string name){
        this.enemyName = name;
    }
    
    //設定血量
    protected void setHealth(int hp){
        this.health = hp;
    }
	
	abstract protected bool fight();    //抽象function，判斷是否進入fight狀態
	abstract protected bool move();     //抽象function，判斷是否進入move狀態
	abstract protected bool death();    //抽象function，判斷是否死亡
  
}
