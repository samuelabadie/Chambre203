using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChoice : MonoBehaviour
{
    public NumberGenerator a;
    public GameManager game;

    // Update is called once per frame
    public void Left()
    {
        if (a.order == 0)
        {
            NextLevel();
        }
        else if (a.order == 1)
        {
            GameOver();
        }
    }

    public void Right()
    {
        if (a.order == 0)
        {
            GameOver();
        }
        else if (a.order == 1)
        {
            NextLevel();
        }
    }

    public void NextLevel()
    {
        Debug.Log("NextLevel");
        game.UpdateCalcul();
    }

    public void GameOver()
    {
        Debug.Log("Fail");
    }
}
