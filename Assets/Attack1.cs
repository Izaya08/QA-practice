using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1 : MonoBehaviour
{
    [SerializeField] private UI ui;

    private void OnGUI() // OnGUI (Using GUI for .Box, .Label)
    {
        if (GUI.Button(new Rect(467, 318, 302, 102), "Attack")) // if(FUNCTION)GUI.(BUTTON)(BOX)(NAME)
        {

        }

    }
}