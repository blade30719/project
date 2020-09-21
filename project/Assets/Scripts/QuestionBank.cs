using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionBank : MonoBehaviour
{
    // Start is called before the first frame update

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
    string[] question = new string[] { "1 + 1 = ?", "2 + 3 = ?", "3 + 4 = ?" };
    string[] answer1 = new string[] { "2", "1", "8" };
    string[] answer2 = new string[] { "9", "6", "2" };
    string[] answer3 = new string[] { "5", "5", "7" };
    string[] answer4 = new string[] { "7", "0", "6" };
    string[] answer5 = new string[] { "2", "5", "7" };
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
        num = Random.Range(0, 3);
        Debug.Log(num);
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
        if (!Answer.Equals("")) {
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
