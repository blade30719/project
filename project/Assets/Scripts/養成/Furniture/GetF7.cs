using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetF7 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.F7.ToString();   
    }

    /*public void ClickF7() 
    {
        SystemStorage.F7+=1;
    }*/
}
