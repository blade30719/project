using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetF6 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.F6.ToString();   
    }

    /*public void ClickF6() 
    {
        SystemStorage.F6+=1;
    }*/
}
