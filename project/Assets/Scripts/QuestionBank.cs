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
    string[] question = new string[] { "貓的骨頭有幾根?", "貓咪的正常體溫應為?", "貓咪眼睛在黑暗會發亮是因為牠們的視網膜底下有一層什麼構造?" };
    string[] answer1 = new string[] { "200", "35.5~36.5", "絨毛層" };
    string[] answer2 = new string[] { "206", "36.5~38.2", "絨布層" };
    string[] answer3 = new string[] { "230", "37.5~39.2", "絨氈層" };
    string[] answer4 = new string[] { "236", "39.0~40.0", "絨水層" };
    string[] answer5 = new string[] { "230", "37.5~39.2", "絨氈層" };

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
        num = Random.Range(0, 3);           // 取得題號
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
