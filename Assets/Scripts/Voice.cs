using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice : MonoBehaviour
{
    public string[] keywords = new string[] { "up", "down", "left", "right" };
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;
    public float speed = 1;

    public Text results;
    public Image target;

    protected PhraseRecognizer recognizer;
    protected string word = "right";

    private void Start()
    {
        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
        results.text = "You said: <b>" + word + "</b>";
    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }
}
