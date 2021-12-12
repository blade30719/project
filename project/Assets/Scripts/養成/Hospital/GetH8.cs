using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetH8 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.H8.ToString();
    }
}
