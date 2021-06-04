using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jumpToNextScene()                          //跳至下個場景
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;          //取得現在場景編號
        SceneManager.LoadScene(currentScene + 1);
    }

    public void jumpToPreviousScene()                     //回到前個場景
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;          //取得現在場景編號
        SceneManager.LoadScene(currentScene - 1);
    }

    public void restartScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;          //取得現在場景編號
        SceneManager.LoadScene(currentScene);
    }

    public void backToHome()
    {
        SceneManager.LoadScene("Home");
        GameObject.Find("Main Camera").GetComponent<TimePause>().setTimeScale(true);
    }

    public void nextKnowLedge()
    {
        SceneManager.LoadScene("Knowledge");
    }
}
