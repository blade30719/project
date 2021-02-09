using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetC4 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.C4.ToString();    
    }
}
