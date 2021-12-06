using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetH4 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.H4.ToString();
    }
}
