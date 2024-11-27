using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2 : MonoBehaviour
{
    [SerializeField] private UI ui;

    private void OnGUI() // OnGUI (Using GUI for .Box, .Label)
    {
        if (GUI.Button(new Rect(473, 471, 292, 155), "Attack Player")) // if(FUNCTION)GUI.(BUTTON)(BOX)(NAME)
        {

        }

    }
}
