using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetH1 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.H1.ToString();
    }
}
