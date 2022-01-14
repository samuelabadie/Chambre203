using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerRightDoor : MonoBehaviour
{

    public NumberGenerator a; //Bidule Bidule
    public TMP_Text Answer;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PrintAnswer()
    {
        if (a.order == 0)
        {
            Answer.text = (a.bad + " ");
        }
        else
        {
            Answer.text = (a.good + " ");
        }
    }
}