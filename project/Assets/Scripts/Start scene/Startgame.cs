using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
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
        SceneManager.LoadScene("StartScene");
    }
    public void nextScene()//切換場景
    {
        if(SystemStorage.count==0){ //取得靜態的數值
            SceneManager.LoadScene("Home");
            SystemStorage.count++;
        }else{
            SceneManager.LoadScene("SampleScene");//切換到編號2的場景
        }
    }
    
}