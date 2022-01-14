using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    const int TRUEVAL = 203;
    public int operationVal, good, bad, typeCalc, order = 0;


    public void numberGen()
    {
        Debug.Log("'Launch NG");
        operationVal = Random.Range(0, 500); //Obtenir la premi?re valeur de l'op?ration
        typeCalc = Random.Range(0, 2); //Obtenir type de calcul (si addition ou soustraction)

        Debug.Log(good);

        if (typeCalc == 0) //Addition
        {
            good = TRUEVAL - operationVal;
        }
        else if (typeCalc == 1) //Soustraction
        {
            good = operationVal - TRUEVAL; //203-x = y, pour x+y = 203
        }

        bad = BadValue(good);
        order = Random.Range(0, 2); //droite ou gauche

        Debug.Log(good);
    }

    public int BadValue(int good) // g?n?re la mauvaise r?ponse, ? faire un good - (TRUEVAL - NomScript.StaticVariable -1) et l'inverse pour la borne sup?rieure
    {
        int notGood = 0;
        do
        {
            notGood = Random.Range(good - 25, good + 25);
        } while (notGood == good); //si valeur notgood == good, alors on refait

        return notGood;
    }

    public int[] returnValues()
    {
        int[] res = {operationVal, good, bad, typeCalc, order};
        return res;
    }


}