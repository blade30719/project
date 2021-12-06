using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetH6 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.H6.ToString();
    }
}
