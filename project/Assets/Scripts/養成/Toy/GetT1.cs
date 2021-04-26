using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetT1 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.T1.ToString();   
    }
}


