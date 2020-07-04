using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class enemyParent : MonoBehaviour
{
 
	private string enemyName;
	private int health = 0;
	
	public enemyParent(string name, int health){
	    this.enemyName = name;
        this.health = health;
	}
    
    public string getName(){
        return enemyName;
    }
    
    public int getHealth(){
        return health;
    }
    
    public void setName(string name){
        this.enemyName = name;
    }
    
    public void setHealth(int hp){
        this.health = hp;
    }
	
	abstract public bool fight();
	abstract public bool move();
	abstract public bool death();   
  
}
