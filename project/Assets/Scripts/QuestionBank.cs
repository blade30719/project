using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionBank : MonoBehaviour
{
    // Start is called before the first frame update

    // 宣告gameobject
    [SerializeField] private TextMeshProUGUI title;
    [SerializeField] private TextMeshProUGUI btn1;
    [SerializeField] private TextMeshProUGUI btn2;
    [SerializeField] private TextMeshProUGUI btn3;
    [SerializeField] private TextMeshProUGUI btn4;
    [SerializeField] GameObject 題目;
    [SerializeField] GameObject 答對;
    [SerializeField] GameObject 答錯;

    private string Answer = "";

    public int num = 0;

    //設定題目
    string[] question = new string[] {"有很多人對貓的毛髮過敏?","孕婦是否能夠養貓?","幼年貓咪平均一天吃幾餐?","你可以為貓咪準備什麼玩具?","貓咪不能吃什麼食物?", "貓咪刷牙的頻率應為多久一次?","貓咪最好少吃哪一種魚?","貓咪的正常體溫應為?","下列的花哪一種對貓咪來說毒性最強?","貓咪常見的體內寄生蟲?"};
    string[] answer1 = new string[] {"是",                         "是",                 "兩餐",                "逗貓棒",                 "酪梨",                "不用刷牙",              "秋刀魚",           "攝氏35.5~36.2",             "牽牛花",                       "蛔蟲"};
    string[] answer2 = new string[] {"否",                         "否",                 "三餐",                "貓抓板",                  "巧克力",              "一天一次",               "沙丁魚",          "攝氏36.5~38.2",             "百合",                        "鉤蟲"};
    string[] answer3 = new string[] {" ",                          " ",                  "四餐",               "毛絨玩具",                 "葡萄",                "一天兩次",              "比目魚",          "攝氏37.5~39.2",              "向日葵",                      "球蟲"};
    string[] answer4 = new string[] {" ",                          " ",                 "多於五餐",            "以上皆是",                 "以上皆是",             "一周一次",              "吳郭魚",          "攝氏39.0~40.0",              "以上皆是",                    "以上皆是"};
    string[] answer5 = new string[] {"否",                         "是",                "多於五餐",            "以上皆是",                 "以上皆是",             "一天一次",              "秋刀魚",          "攝氏37.5~39.2",              "百合",                        "以上皆是"};


    /*
    string[] question = new string[1000];
    string[] answer1 = new string[1000];
    string[] answer2 = new string[1000];
    string[] answer3 = new string[1000];
    string[] answer4 = new string[1000];
    string[] answer5 = new string[1000] ;
    */
    
    void Start()
    {
        
        
        //num = Random.Range(0, 9);           // 取得題號
        SystemStorage.Question += 1;
        num = SystemStorage.Question;
        Debug.Log(num);

        // 印出題目
        title.text = question[num];
        btn1.text = answer1[num];
        btn2.text = answer2[num];
        btn3.text = answer3[num];
        btn4.text = answer4[num];
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Answer);
        if (!Answer.Equals("")) {                 // 判斷是否點擊
            if (Answer.Equals(answer5[num]))
            {
                題目.SetActive(false);
                答對.SetActive(true);
            }
            else
            {
                題目.SetActive(false);
                答錯.SetActive(true);
            }
        }
    }

    // button點擊回傳值(用於判斷是否正確)
    public void button1() {
        Debug.Log(num);
        Answer = answer1[num].ToString();
        Debug.Log(Answer);
    }
    public void button2() {
        Debug.Log(num);
        Answer = answer2[num].ToString();
        Debug.Log(Answer);
    }
    public void button3() {
        Debug.Log(num);
        Answer = answer3[num].ToString();
        Debug.Log(Answer);
    }
    public void button4() {
        Debug.Log(num);
        Answer = answer4[num].ToString();
        Debug.Log(Answer);
    }
}
