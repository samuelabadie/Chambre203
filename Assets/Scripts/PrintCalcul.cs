using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrintCalcul : MonoBehaviour
{
    public NumberGenerator a;
    public TMP_Text GoodText;
    public int Operator, Number = 0;

   
    public int PrintClc()
    {
        Operator = a.typeCalc;
        Number = a.operationVal;
        if (Operator == 0)
        {
            GoodText.text = (Number + " + ...");
        }
        else
        {
            GoodText.text = (Number + " - ...");
        }

        return 0;
    }
}
