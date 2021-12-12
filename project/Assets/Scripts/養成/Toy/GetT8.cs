using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetT8 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.T8.ToString();
    }
}


