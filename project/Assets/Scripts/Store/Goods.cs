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
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);//產生canvasPrefab
        Destroy(GameObject.Find("Hospital(Clone)"));//刪掉canvas1
        Destroy(GameObject.Find("Furniture(Clone)"));//刪掉canvas2
        Destroy(GameObject.Find("Toy(Clone)"));//刪掉canvas3
    }
    public void OnClickHos()
    {
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);//產生canvasPrefab
        Destroy(GameObject.Find("Food(Clone)"));//刪掉canvas1
        Destroy(GameObject.Find("Furniture(Clone)"));//刪掉canvas2
        Destroy(GameObject.Find("Toy(Clone)"));//刪掉canvas3
    }
    public void OnClickFur()
    {
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);//產生canvasPrefab
        Destroy(GameObject.Find("Food(Clone)"));//刪掉canvas1
        Destroy(GameObject.Find("Hospital(Clone)"));//刪掉canvas2
        Destroy(GameObject.Find("Toy(Clone)"));//刪掉canvas3
    }
    public void OnClickToy()
    {
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);//產生canvasPrefab
        Destroy(GameObject.Find("Food(Clone)"));//刪掉canvas1
        Destroy(GameObject.Find("Hospital(Clone)"));//刪掉canvas2
        Destroy(GameObject.Find("Furniture(Clone)"));//刪掉canvas3
    }
}