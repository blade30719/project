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
        SceneManager.LoadScene(0);//編號0的場景
    }
    public void nextScene()//切換場景
    {
        if(SystemStorage.count==0){ //取得靜態的數值
            SceneManager.LoadScene(2);//切換到編號1的場景
            SystemStorage.count++;
        }else{
            SceneManager.LoadScene(1);//切換到編號2的場景
        }
    }
    
}
