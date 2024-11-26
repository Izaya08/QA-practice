using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GUIStyle Style; //GUIStyle (Decoration) Style (Label) (Stats) Referencing (string)
    public Vector2 position; //MOVING BOX POSITION
    public Vector2 size; //MOVING BOX SIZE

    public string Stats = "Health: \nDefense:"; // String(function, reference word), ("name", "label") "(label), (: \n)(Layout), (label), (:";)(End line)

    private void OnGUI() // OnGUI (Using GUI for .Box, .Label)
    {
        GUI.Box(new Rect(position, size), ""); // Measuring Tape 

        GUI.Box(new Rect(120, 113, 1601, 816), ""); // actual measurement

        GUI.Box(new Rect(899, 166, 595, 418), ""); // actual measurement

        GUI.Label(new Rect(158, 136, 181, 86), "Characters"); // Measuring Tape (Label) ("Characters") Is name, Box for name 

        GUI.Box(new Rect(899, 166, 595, 418), ""); // Measuring Tape (Label) ("name") Is name, Box for name

        GUI.Label(new Rect(899, 166, 595, 418), Stats, Style); // Measuring Tape (Label) (Stats) Referencing (string)
    }

}
