using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetC5 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.C5.ToString();    
    }
}
