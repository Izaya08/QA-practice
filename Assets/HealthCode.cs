using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCode : MonoBehaviour
{

    [SerializeField] private Player1 player1;
    [SerializeField] private Player2 player2;
    [SerializeField] private Player3 player3;

    private GUIStyle style; 

    public int hatdog;
    public string healthLOL = "Health";

    private void OnGUI()
    {
        if (GUI.Button(new Rect(509, 256, 218, 55), "Lock In"))
        {
            healthLOL = "Health" + hatdog;
        }

        GUI.Label(new Rect(412, 430, 429, 236), healthLOL);
    }
}
