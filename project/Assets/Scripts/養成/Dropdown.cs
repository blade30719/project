using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown : MonoBehaviour
{

    /*[SerializeField] private*/
    Dropdown m_Dropdown;
    public GameObject canvasPrefab1;//要產生的canvas
    public GameObject canvasPrefab2;
    public GameObject canvasPrefab3;
    public GameObject canvasPrefab4;

    void Start(){
      //m_Dropdown = GetComponent<Dropdown>();
      //Debug.Log(m_Dropdown.value);
    }

    public void InputData(int val)
    {
      Debug.Log("我進來了");
      if (val == 0){
        Instantiate (canvasPrefab1, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包家具
      }
      else if (val == 1){
        Instantiate (canvasPrefab2, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包食物
      }
      else if (val == 2){
        Instantiate (canvasPrefab3, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包AA
      }
      else{
        Instantiate (canvasPrefab4, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包BB
      }

    }      
    
}
