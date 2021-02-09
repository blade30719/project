using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetF5 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.F5.ToString();   
    }
}
