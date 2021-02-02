using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UI.Dropdown;



public class DrMenu : MonoBehaviour
{
    // Start is called before the first frame update
    Dropdown m_Dropdown;
    public GameObject canvasPrefab1;//要產生的canvas
    public GameObject canvasPrefab2;
    public GameObject canvasPrefab3;
    public GameObject canvasPrefab4;
    //[SerializeField]
    //private int value  = -1;

    void Start(){
      //m_Dropdown = GetComponent<Dropdown>();
      //Debug.Log(m_Dropdown.value);
    }
   
    public void InputData(int val)
    {
      if (val == 0){
        Debug.Log(val);
        Instantiate (canvasPrefab1, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包家具
        //Dropdown.Value = -1 ;
      }
      else if (val == 1){
        Debug.Log(val);
        Instantiate (canvasPrefab2, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包食物
      }
      else if (val == 2){
        Debug.Log(val);
        Instantiate (canvasPrefab3, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包AA
      }
      else{
        Debug.Log(val);
        Instantiate (canvasPrefab4, Vector2.zero, Quaternion.identity);//產生canvasPrefab-背包BB
      }

    }

   
}
