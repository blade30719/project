using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetH3 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.H3.ToString();
    }
}
