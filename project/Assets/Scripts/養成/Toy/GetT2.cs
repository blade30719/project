using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetT2 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = SystemStorage.T2.ToString();
    }
}
