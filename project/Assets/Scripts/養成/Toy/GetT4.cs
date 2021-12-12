using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetT4 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.T4.ToString();
    }
}


