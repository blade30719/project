using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Board : MonoBehaviour//黑板
{
    Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani= GetComponent<Animator>();//ani=所掛對象Animator
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {
        ani.SetTrigger("board");//開始動畫
    }
}
