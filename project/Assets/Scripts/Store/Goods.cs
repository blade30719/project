using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goods : MonoBehaviour
{
    public GameObject canvasPrefab;//要產生的canvas
  

    void Start()
    {
        
    }
    
    public void OnClickFood()
    {
        Destroy(GameObject.Find("Food(Clone)"));//刪掉canvas1
        Destroy(GameObject.Find("Hospital(Clone)"));//刪掉canvas2
        Destroy(GameObject.Find("Furniture(Clone)"));//刪掉canvas3
        Destroy(GameObject.Find("Toy(Clone)"));//刪掉canvas4
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);//產生canvasPrefab
    }
    public void OnClickHos()
    {
        Destroy(GameObject.Find("Food(Clone)"));//刪掉canvas1
        Destroy(GameObject.Find("Hospital(Clone)"));//刪掉canvas2
        Destroy(GameObject.Find("Furniture(Clone)"));//刪掉canvas3
        Destroy(GameObject.Find("Toy(Clone)"));//刪掉canvas4
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);//產生canvasPrefab
    }
    public void OnClickFur()
    {
        Destroy(GameObject.Find("Food(Clone)"));//刪掉canvas1
        Destroy(GameObject.Find("Hospital(Clone)"));//刪掉canvas2
        Destroy(GameObject.Find("Furniture(Clone)"));//刪掉canvas3
        Destroy(GameObject.Find("Toy(Clone)"));//刪掉canvas4
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);//產生canvasPrefab
    }
    public void OnClickToy()
    {
        Destroy(GameObject.Find("Food(Clone)"));//刪掉canvas1
        Destroy(GameObject.Find("Hospital(Clone)"));//刪掉canvas2
        Destroy(GameObject.Find("Furniture(Clone)"));//刪掉canvas3
        Destroy(GameObject.Find("Toy(Clone)"));//刪掉canvas4
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);//產生canvasPrefab
    }
}