using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetC2 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.C2.ToString();    
    }
}
