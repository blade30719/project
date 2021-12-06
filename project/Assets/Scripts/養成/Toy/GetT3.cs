using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetT3 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.T3.ToString();
    }
}


