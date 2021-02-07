using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetF8 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.F8.ToString();   
    }

    /*public void ClickF8() 
    {
        SystemStorage.F8+=1;
    }*/
}
