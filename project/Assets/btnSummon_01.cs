using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnSummon_01 : MonoBehaviour
{

    public float coldTime = 2.0f;  //按鈕冷卻時間
    private float timer = 0;  //計時器
    private Image filledImage;  //CD轉圈的圖示
    private bool isStartTime = false;  //決定是否開始計時
    [SerializeField] private GameObject RiceBall;  //Cat Stick prefab
    [SerializeField] private Transform Friendly_Position;  //出怪點
    [SerializeField] private GameObject camera1;
    [SerializeField] private GameObject 黑底;
    [SerializeField] private GameObject TMP;
    [SerializeField] private GameObject 箭頭;
    // Start is called before the first frame update
    void Start()
    {
        filledImage = transform.Find("Cold Image").GetComponent<Image>(); //將圖示抓進來
    }

    // Update is called once per frame
    void Update()
    {
        if (isStartTime)  //當isStartTime為true
        {
            timer += Time.deltaTime;
            filledImage.fillAmount = (coldTime - timer) / coldTime; //按照冷卻時間顯示轉圈圖示
            if (timer >= coldTime) //判斷冷卻是否結束
            {
                filledImage.fillAmount = 0; //冷卻圖示取消
                timer = 0; //重置計時器
                isStartTime = false; //計時結束
            }
            camera1.GetComponent<TimePause>().setTimeScale(true);             //按下安鈕後取消暫停
            黑底.SetActive(false);
            TMP.SetActive(false);
            箭頭.SetActive(false);
        }
    }

    public void OnShow() //按鈕觸發後
    {
        if (isStartTime == false)
        {
            isStartTime = true; //點擊按鈕後開始計時
            Debug.Log("按下召喚01");
                //下面為召喚Summon_01的位置
                Vector3 pos = new Vector3(8,-7,-1); //宣告位置pos，Random.Range
                Instantiate(RiceBall,Friendly_Position.position,Friendly_Position.rotation);
        }
    }

}
