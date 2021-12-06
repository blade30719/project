using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyH : MonoBehaviour
{
    public GameObject canvasPrefab;//要產生的canvas
    public void BuyH1()
    {

        if ((SystemStorage.coin - 5) < 0)
        {
            Debug.Log("餘額不足");
            Instantiate(canvasPrefab, Vector2.zero, Quaternion.identity);//產生canvasPrefab
        }
        else
        {
            SystemStorage.coin -= 5;
            SystemStorage.H1 += 1;
        }

    }

    public void BuyH2()
    {

        if ((SystemStorage.coin - 5) < 0)
        {
            Debug.Log("餘額不足");
        }
        else
        {
            SystemStorage.coin -= 5;
            SystemStorage.H2 += 1;
        }

    }

    public void BuyH3()
    {

        if ((SystemStorage.coin - 10) < 0)
        {
            Debug.Log("餘額不足");
        }
        else
        {
            SystemStorage.coin -= 10;
            SystemStorage.H3 += 1;
        }

    }

    public void BuyH4()
    {

        if ((SystemStorage.coin - 10) < 0)
        {
            Debug.Log("餘額不足");
        }
        else
        {
            SystemStorage.coin -= 10;
            SystemStorage.H4 += 1;
        }

    }

    public void BuyH5()
    {

        if ((SystemStorage.coin - 15) < 0)
        {
            Debug.Log("餘額不足");
        }
        else
        {
            SystemStorage.coin -= 15;
            SystemStorage.H5 += 1;
        }

    }

    public void BuyH6()
    {

        if ((SystemStorage.coin - 15) < 0)
        {
            Debug.Log("餘額不足");
        }
        else
        {
            SystemStorage.coin -= 15;
            SystemStorage.H6 += 1;
        }

    }

    public void BuyH7()
    {

        if ((SystemStorage.coin - 20) < 0)
        {
            Debug.Log("餘額不足");
        }
        else
        {
            SystemStorage.coin -= 20;
            SystemStorage.H7 += 1;
        }

    }

    public void BuyH8()
    {

        if ((SystemStorage.coin - 20) < 0)
        {
            Debug.Log("餘額不足");
        }
        else
        {
            SystemStorage.coin -= 20;
            SystemStorage.H8 += 1;
        }

    }
}
