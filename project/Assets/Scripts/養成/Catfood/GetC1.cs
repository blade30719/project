using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetC1 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.C1.ToString();    
    }
}
