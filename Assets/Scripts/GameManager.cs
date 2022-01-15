using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int level, score = 0;
    public NumberGenerator a;
    public PrintCalcul b;
    public AnswerLeftDoor left;
    public AnswerRightDoor right;
    public bool Over = false;

    // Start is called before the first frame update
    void Start()
    {
        level = 0;
        score = 0;
        Over = false;
        a.numberGen();  
        b.PrintClc();
        left.PrintAnswer();
        right.PrintAnswer();

    }

    // Update is called once per frame
    void Update()
    {
        GetArrow();
    }
    public void UpdateCalcul()
    {
        a.numberGen();
        print(b.PrintClc());
        left.PrintAnswer();
    }

    public void GetArrow()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("fleche de gauche");
            Debug.Log(left.Answer.text);

            if (a.good.ToString()==left.Answer.text) 
            {
                Debug.Log("bien joué");

            }
            else
            {
                Debug.Log("Fail");
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("fleche de droite");
            Debug.Log(right.Answer.text);

            if (a.good.ToString() == right.Answer.text)
            {
                Debug.Log("bien joué");
            }
            else
            {
                Debug.Log("Fail");
            }
        }


    }


}
