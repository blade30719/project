using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetT5 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.T5.ToString();
    }
}


