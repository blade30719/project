using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStickSummon : MonoBehaviour
{
    // Start is called before the first frame update
    float summonTime = 25.0f;
    [SerializeField] private GameObject catStick;
    [SerializeField] private Transform Enemy_Position;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, summonTime); // 重複呼叫SpawnEnemy function()、0延遲開場就做、每summonTime秒呼叫
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy(){
        //主堡沒爆
        //if(){
            Vector3 pos = new Vector3(-19,-7,-1); //宣告位置pos，Random.Range
            Instantiate(catStick,Enemy_Position.position,Enemy_Position.rotation);
       // }
    }

}
