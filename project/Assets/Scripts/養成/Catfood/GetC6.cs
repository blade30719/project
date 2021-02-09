using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetC6 : MonoBehaviour
{
    void Update()
    {
       GetComponent<Text>().text=SystemStorage.C6.ToString();    
    }
}
