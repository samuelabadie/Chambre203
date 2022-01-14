using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerLeftDoor : MonoBehaviour
{

    public NumberGenerator a;
    public TMP_Text Answer;
    // Start is called before the first frame update
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
            Answer.text = (a.good + " ") ;
        }
        else
        {
            Answer.text = (a.bad + " ");
        }
    }
}
