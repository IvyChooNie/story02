using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s1 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {

        keywords.Add("lion", () =>
        {
            GoCalled10();
        });

        keywords.Add("rabbit", () =>
        {
            GoCalled11();
        });

        keywords.Add("mouse", () =>
        {
            GoCalled12();
        });
    

    keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
    keywordRecognizer.OnPhraseRecognized += KeywordRecognizerOnPhraseRecognizer;
        keywordRecognizer.Start();
    }

void KeywordRecognizerOnPhraseRecognizer(PhraseRecognizedEventArgs args)
{
    System.Action keywordAction;

    if (keywords.TryGetValue(args.text, out keywordAction))
    {
        keywordAction.Invoke();
    }
}
void GoCalled10()
{
    Debug.Log("The answer is rabbit!");
    //this.transform.Translate(Vector3.up * 10.0f);
   // ScoreBoard.Score -= 2;
}
void GoCalled11()
{
    Debug.Log("The answer is rabbit!");
    //this.transform.Translate(Vector3.up * 10.0f);
    // ScoreBoard.Score -= 2;
}

void GoCalled12()
{
    Debug.Log("The answer is rabbit!");
    //this.transform.Translate(Vector3.up * 10.0f);
    // ScoreBoard.Score -= 2;
}
}
