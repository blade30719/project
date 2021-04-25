using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startScene()//開始場景
    {
        SceneManager.LoadScene("Home");
    }
    public void nextScene()//切換場景
    {
        SceneManager.LoadScene("SampleScene");
    }
}
