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
        a.numberGen();  
        b.PrintClc();
        left.PrintAnswer();
        right.PrintAnswer();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateCalcul()
    {
        a.numberGen();
        print(b.PrintClc());
        left.PrintAnswer();
    }


}
