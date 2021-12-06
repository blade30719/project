using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetT7 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.T7.ToString();
    }
}


