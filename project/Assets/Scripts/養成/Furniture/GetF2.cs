﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetF2 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.F2.ToString();   
    }
}
