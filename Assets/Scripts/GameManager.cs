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

    public void Update()
    {
        key.KeyInput();
    }
    public void UpdateCalcul()
    {
        Debug.Log("Update");
        a.numberGen();
        b.PrintClc();
        left.PrintAnswer();
        right.PrintAnswer();
    }

}
