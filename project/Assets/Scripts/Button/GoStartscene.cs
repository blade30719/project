using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoStartscene : MonoBehaviour
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
        SceneManager.LoadScene(2);//編號2的場景
    }
    public void nextScene()//切換場景
    {
        SceneManager.LoadScene(0);//切換到編號0的場景
        
    }
    
}
