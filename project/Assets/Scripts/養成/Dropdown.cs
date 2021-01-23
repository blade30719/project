using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown : MonoBehaviour
{
    public GameObject canvasPrefab1;//要產生的canvas
    public GameObject canvasPrefab2;//要產生的canvas
    public GameObject canvasPrefab3;//要產生的canvas
    public GameObject canvasPrefab4;//要產生的canvas

    public void InputData(int val)
    {
      if (val == 0){
        Instantiate (canvasPrefab1, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包家具
      }
      if (val == 1){
        Instantiate (canvasPrefab2, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包食物
      }
      else if (val == 2){
        Instantiate (canvasPrefab3, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包AA
      }
      else if (val == 3){
        Instantiate (canvasPrefab4, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包BB
      }

    }      
    
}
