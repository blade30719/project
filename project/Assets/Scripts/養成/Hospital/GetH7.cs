using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetH7 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.H7.ToString();
    }
}
