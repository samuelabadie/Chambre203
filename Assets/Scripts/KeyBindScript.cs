using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBindScript : MonoBehaviour
{
    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();
    public Text left, right, pause;
    private GameObject currentKey;
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
        if (Input.GetKeyDown(keys["Gauche"]))
        {
            Debug.Log("Gauche");
        }
        if (Input.GetKeyDown(keys["Droite"]))
        {
            Debug.Log("Droite");
        }
        if (Input.GetKeyDown(keys["Pause"]))
        {
            Debug.Log("Pause");
        }
    }

    private void OnGUI()
    {
        if (currentKey != null)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                keys[currentKey.name] = e.keyCode;
                currentKey.GetComponent<Text>().text = e.keyCode.ToString();
                currentKey = null;
            }
        }
    }

    public void changeKey(GameObject clicked)
    {
        currentKey = clicked;
    }
}
