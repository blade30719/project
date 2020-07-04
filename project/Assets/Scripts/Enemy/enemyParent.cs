using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class enemyParent : MonoBehaviour
{
 
	private string name;
	private int health;
	
	public enemyParent(string name, int health){
	    this.name = name;
        this.health = health;
	}
    
    public string getName(){
        return name;
    }
    
    public int getHealth(){
        return health;
    }
    
    public void setName(string name){
        this.name = name;
    }
    
    public void setHealth(int hp){
        this.health = hp;
    }
	
	abstract public bool fight();
	abstract public bool move();
	abstract public bool death();   
  
}
