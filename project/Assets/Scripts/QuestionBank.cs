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
    void Start()
    {

        int num = Random.Range(0,2);
        string[] question = new string[] { "1 + 1 = ?", "2 + 3 = ?" , "3 + 4 = ?" };
        string[] answer1 = new string[] { "2" , "1" , "8" };
        string[] answer2 = new string[] { "9" , "6" , "2" };
        string[] answer3 = new string[] { "5" , "5" , "7" };
        string[] answer4 = new string[] { "7" , "0" , "6" };
        string[] answer5 = new string[] { "2" , "5" , "7" };

        title.text = question[num];
        btn1.text = answer1[num];
        btn2.text = answer2[num];
        btn3.text = answer3[num];
        btn4.text = answer4[num];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
