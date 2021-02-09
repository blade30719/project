using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetF3 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.F3.ToString();   
    }
}
