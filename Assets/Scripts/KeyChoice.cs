using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChoice : MonoBehaviour
{
    public NumberGenerator a;
    public GameManager game;

    // Update is called once per frame
    public void KeyInput()
    {
        if (Input.GetKey("left"))
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
        else if (Input.GetKey("right"))
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

        else if (Input.GetKey("right"))
        {
            Debug.Log("right");
        }
    }

    public void NextLevel()
    {
        game.level += 1;
        game.score += 1;
    }

    public void GameOver()
    {
        Debug.Log("Fail");
    }
}
