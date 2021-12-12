using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetH2 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.H2.ToString();
    }
}
