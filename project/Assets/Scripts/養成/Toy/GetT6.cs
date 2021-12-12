using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetT6 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.T6.ToString();
    }
}


