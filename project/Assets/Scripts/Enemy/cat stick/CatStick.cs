using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStick : enemyParent
{

    public CatStick(string name , int heath) : base("catStick" , 2)
    {
        setName("catStick");
        setHealth(2);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
