using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBindScript : MonoBehaviour
{
    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();
    public Text left, right, pause;
    // Start is called before the first frame update
    void Start()
    {
        keys.Add("Gauche", KeyCode.LeftArrow);
        keys.Add("Droite", KeyCode.RightArrow);
        keys.Add("Pause", KeyCode.Escape);

        left.text = keys["Gauche"].ToString();
        right.text = keys["Droite"].ToString();
        pause.text = keys["Pause"].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
