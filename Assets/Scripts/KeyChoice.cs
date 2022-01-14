using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChoice : MonoBehaviour
{
    public NumberGenerator a;
    public GameManager game;
    public bool choiceMade = false;

    // Update is called once per frame
    public void KeyInput() //Gauche Droite
    {

        while (choiceMade == false)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("Left");
                choiceMade = true;
                if (a.order == 0)
                {
                    NextLevel();
                }
                else if (a.order == 1)
                {
                    GameOver();
                }
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("Right");
                choiceMade = true;
                if (a.order == 0)
                {
                    GameOver();
                }
                else if (a.order == 1)
                {
                    NextLevel();
                }
            }
        }
    }

    public void NextLevel()
    {
        Debug.Log("NextLevel");
        game.level += 1;
        game.score += 1;
        choiceMade = false;
        game.UpdateCalcul();
    }

    public void GameOver()
    {
        choiceMade = false;
        Debug.Log("Fail");
    }
}
