using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : Abstract
{
    [SerializeField] private UI ui; //SerializeField(So i can use it) UI ui (Referencing using diff name) 


    public GUIStyle Style; //GUIStyle (Decoration) Style (Label) (Stats) Referencing (string)
    public Vector2 position; //MOVING BOX POSITION
    public Vector2 size; //MOVING BOX SIZE

    public string Stats = "Health: \nDefense: \nAttack: "; // String(function, reference word), ("name", "label") "(label), (: \n)(Layout), (label), (:";)(End line)
    public string EnemyStats = "Health: \nDefense: \nAttack: "; // String(function, reference word), ("name", "label") "(label), (: \n)(Layout), (label), (:";)(End line)

    private void OnGUI() // OnGUI (Using GUI for .Box, .Label)
    {
        GUI.Box(new Rect(position, size), ""); // Measuring Tape (Label) ("name") Is name, Box for name

        GUI.Box(new Rect(11, 13, 1445, 702), ""); // actual measurement

        GUI.Box(new Rect(882, 76, 538, 363), ""); // actual measurement

        GUI.Box(new Rect(879, 115, 425, 274), ""); // Measuring Tape (Label) ("name") Is name, Box for name

        GUI.Label(new Rect(879, 115, 425, 274), Stats, Style); // Measuring Tape (Label) (Stats) Referencing (string)

        GUI.Box(new Rect(878, 397, 428, 106), ""); // Measuring Tape (Label) ("name") Is name, Box for name

        GUI.Label(new Rect(878, 397, 428, 106), EnemyStats, Style); // Measuring Tape (Label) (Stats) Referencing (string)

        GUI.Box(new Rect(412, 430, 429, 236), ""); // Measuring Tape (Label) ("name") Is name, Box for name

        GUI.Label(new Rect(412, 430, 429, 236), "Health", Style); // Measuring Tape (Label) (Stats) Referencing (string)
    }

    /* [SerializeField] private Player1 player1;
     Player2 player2;
     Player3 player3;

     private void Damage()
     {
         Stats = ("Health: " + Health + "Defense: " + Defense + "\nAttack: " + Attack); //ui.stats (Referencing (UI ui)) Health: " + Health + "\nDefense: " + Defense (Referencing Health + Defense in [SerializeField] (Abstract.cs))
     }*/
}
