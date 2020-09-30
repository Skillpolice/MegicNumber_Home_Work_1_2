using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MagicNum : MonoBehaviour
{
    public Text title;

    public int min;
    public int max;
    int guess;

    int ct = 0;

    void Start()
    {
        ct = 0;
        min = 1;
        max = 1000;
        print("Закадайте число от 1 до " + max);
        UpdateGuess();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) //нажатие клавишы вверх и вычитание среднеарефметичесткого
        {
            min = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) //нажатие клавишы вниз и вычитание среднеарефметичесткого
        {

            max = guess;
            UpdateGuess();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            title.text = "Поздравляем это ваше число " + guess.ToString() + "\n" + "Кол-во потраченых шагов " + ct;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {

            Start();
            title.text = "----------------NEW GAME-------------------";
        }

    }


    void UpdateGuess()
    {
        ct++;
        guess = (min + max) / 2;
        title.text = "ваше число " + guess.ToString() + " ?";

    }

}
