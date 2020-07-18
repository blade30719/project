using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class friendlyParent : MonoBehaviour
{
    private string friendlyName;  //友方名
	private int health = 0;    //友方的血量
    private int attack = 0;    //攻擊力
	
	public friendlyParent(string name, int health , int attack){
	    this.friendlyName = name;
        this.health = health;
        this.attack = attack;
	}
    
    //子類別呼叫取得友方名
    public string getName(){
        return friendlyName;
    }
    
    //子類別呼叫取得血量
    public int getHealth(){
        return health;
    }

    public int getAttack()
    {
        return attack;
    }
    
    //設定友方名
    public void setName(string name){
        this.friendlyName = name;
    }
    
    //設定血量
    public void setHealth(int hp){
        this.health = hp;
    }
	
    public void setAttack(int str)
    {
        this.attack = str;
    }

	abstract public bool fight();    //抽象function，判斷是否進入fight狀態
	abstract public bool move();     //抽象function，判斷是否進入move狀態
	abstract public bool death();    //抽象function，判斷是否死亡
}
