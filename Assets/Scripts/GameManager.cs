using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int level, score = 0;
    public KeyChoice key;
    public NumberGenerator a;
    public PrintCalcul b;
    public AnswerLeftDoor left;
    public AnswerRightDoor right;

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            key.Left();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            key.Right();
        }
    }

    public void UpdateCalcul()
    {
        level += 1;
        score += 1;
        Debug.Log("Update");
        a.numberGen();
        b.PrintClc();
        left.PrintAnswer();
        right.PrintAnswer();
    }

}
