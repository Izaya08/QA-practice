using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Abstract
{
    [SerializeField] private UI ui; //SerializeField(So i can use it) UI ui (Referencing using diff name) 

    private void OnGUI() // OnGUI (Using GUI for .Box, .Label)
    {
        if (GUI.Button(new Rect(91, 566, 263, 87), "Demon King")) // if(FUNCTION)GUI.(BUTTON)(BOX)(NAME)
        {
            ui.Stats = ("Health: " + Health + "Defense: " + Defense + "\nAttack: " + Attack); //ui.stats (Referencing (UI ui)) Health: " + Health + "\nDefense: " + Defense (Referencing Health + Defense in [SerializeField] (Abstract.cs))
        }
    }
}
