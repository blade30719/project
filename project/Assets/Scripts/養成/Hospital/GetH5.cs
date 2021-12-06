using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetH5 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.H5.ToString();
    }
}
