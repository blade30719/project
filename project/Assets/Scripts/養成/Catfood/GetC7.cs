using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetC7 : MonoBehaviour
{
    void Update()
    {
       GetComponent<Text>().text=SystemStorage.C7.ToString();    
    }
}

