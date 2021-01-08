using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score02 : MonoBehaviour
{
    public static int Score = 0;


    private void OnGUI()
    {
        GUI.skin.box.fontSize = 34;
        GUI.Box(new Rect(120, 100, 250, 120), "Score: " + Score.ToString());



    }
}
