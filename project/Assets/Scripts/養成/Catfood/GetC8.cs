using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetC8 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.C8.ToString();    
    }
}
