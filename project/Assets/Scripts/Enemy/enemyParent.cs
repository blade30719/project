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
    public string getName(){
        return enemyName;
    }
    
    //子類別呼叫取得血量
    public int getHealth(){
        return health;
    }
    
    //設定敵人名
    public void setName(string name){
        this.enemyName = name;
    }
    
    //設定血量
    public void setHealth(int hp){
        this.health = hp;
    }
	
	abstract public bool fight();    //抽象function，判斷是否進入fight狀態
	abstract public bool move();     //抽象function，判斷是否進入move狀態
	abstract public bool death();    //抽象function，判斷是否死亡
  
}
