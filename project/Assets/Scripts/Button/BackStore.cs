using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackStore : MonoBehaviour
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
        SceneManager.LoadScene(4);//編號4的場景
    }
    public void nextScene()//切換場景
    {
        SceneManager.LoadScene(3);//切換到編號3的場景
    }
}
