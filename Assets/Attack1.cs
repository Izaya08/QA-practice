using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1 : MonoBehaviour
{
    [SerializeField] private UI ui;

    private void OnGUI() // OnGUI (Using GUI for .Box, .Label)
    {
        if (GUI.Button(new Rect(473, 180, 292, 155), "Attack Demon")) // if(FUNCTION)GUI.(BUTTON)(BOX)(NAME)
        {

        }

    }
}