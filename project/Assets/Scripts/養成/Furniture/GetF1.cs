using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetF1 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.F1.ToString();   
    }

    /*public void ClickF1() 
    {
        SystemStorage.F1+=1;
    }*/
}
