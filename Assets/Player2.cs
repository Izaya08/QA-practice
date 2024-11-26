using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Abstract //Referencing "Abstract"
{
    [SerializeField] private UI ui; //SerializeField(So i can use it) UI ui (Referencing using diff name) 
    private void OnGUI() // OnGUI (Using GUI for .Box, .Label)
    {
        if (GUI.Button(new Rect(218, 335, 230, 93), "Archer")) // if(FUNCTION)GUI.(BUTTON)(BOX)(NAME)
        {
            ui.Stats = ("Health: " + Health + "\nDefense: " + Defense); //ui.stats (Referencing (UI ui)) Health: " + Health + "\nDefense: " + Defense (Referencing Health + Defense in [SerializeField] (Abstract.cs))
        }
    }
}