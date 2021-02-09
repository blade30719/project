using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetC3 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.C3.ToString();    
    }
}
