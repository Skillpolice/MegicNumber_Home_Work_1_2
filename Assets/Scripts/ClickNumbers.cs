using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.UI;

public class ClickNumbers : MonoBehaviour
{
    public Text title;

    int sum;
    public int allSum = 50;
    int ct;

    void Start()
    {
        
    }


    void Update()
    {
        if (sum < allSum)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                sum += 1;
                ct++;
            }
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                sum += 2;
                ct++;
            }
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                sum += 3;
                ct++;
            }
            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                sum += 4;
                ct++;
            }
            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                sum += 5;
                ct += 1;
            }
            if (Input.GetKeyDown(KeyCode.Keypad6))
            {
                sum += 6;
                ct++;
            }
            if (Input.GetKeyDown(KeyCode.Keypad7))
            {
                sum += 7;
                ct++;
            }
            if (Input.GetKeyDown(KeyCode.Keypad8))
            {
                sum += 8;
                ct++;
            }
            if (Input.GetKeyDown(KeyCode.Keypad9))
            {
                sum += 9;
                ct++;
            }
        }

        GetSum();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ct = 0;
            sum = 0;
            Start();
        }

    }



    public void GetSum()
    {
      
        title.text = "Нажимайте клавиши от 1 до 9" + "\n" +  "Summa = " + sum.ToString() + "\n" + " Кол-во проходов в нoги)) " + ct;
        if (sum >= allSum)
        {
            title.text = "Game Over" + "\n" + "Summa =" + sum + "\n" + " Кол-во проходов в нoги)) " + ct;
        }

    }
}
