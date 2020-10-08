using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Text numberText;
    public MagicNum maicNum;
    void Start()
    {
        maicNum = FindObjectOfType<MagicNum>();

        int number = maicNum.guess;
        numberText.text = number.ToString();
    }

}
