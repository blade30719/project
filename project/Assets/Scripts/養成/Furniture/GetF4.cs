using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetF4 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.F4.ToString();   
    }
}
