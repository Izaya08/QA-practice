using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GUIStyle Style; //GUIStyle (Decoration) Style (Label) (Stats) Referencing (string)
    public Vector2 position; //MOVING BOX POSITION
    public Vector2 size; //MOVING BOX SIZE

    public string Stats = "Health: \nDefense: \nAttack: " ; // String(function, reference word), ("name", "label") "(label), (: \n)(Layout), (label), (:";)(End line)

    private void OnGUI() // OnGUI (Using GUI for .Box, .Label)
    {
        GUI.Box(new Rect(position, size), ""); // Measuring Tape (Label) ("name") Is name, Box for name

        GUI.Box(new Rect(11, 13, 1445, 702), ""); // actual measurement

        GUI.Box(new Rect(882, 76, 538, 363), ""); // actual measurement

        GUI.Box(new Rect(882, 76, 538, 363), ""); // Measuring Tape (Label) ("name") Is name, Box for name

        GUI.Label(new Rect(882, 76, 538, 363), Stats, Style); // Measuring Tape (Label) (Stats) Referencing (string)

        GUI.Box(new Rect(963, 507, 379, 155), ""); // actual measurement
    }
}
