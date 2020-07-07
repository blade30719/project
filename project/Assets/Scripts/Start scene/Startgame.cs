using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Startgame : MonoBehaviour
{
    //int currentScene;
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
        SceneManager.LoadScene(0);//第一個
    }
    public void nextScene()//切換場景
    {
        SceneManager.LoadScene(1);//切換到下個
    }
    
}
