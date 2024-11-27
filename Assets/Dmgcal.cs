using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dmgcal : MonoBehaviour
{
    [SerializeField] UI ui;
    [SerializeField] HealthCode healthCode;
    [SerializeField] Boss boss;

    public GUIStyle style;



    private int Damage = 27;

    public string newHealth = "Health: ";

    public string Lost = "";


    private void OnGUI()
    {


        if (GUI.Button(new Rect(594, 401, 319, 146), "Damage: " + Damage))
        {
            healthCode.gHealth -= Damage;
            healthCode.ggHealth = "Health: " + healthCode.gHealth;

            healthCode.Health -= Damage;
            boss.demon = ("Demon \nHealth: " + boss.Health + "\nDefense: " + boss.Defense + "\nAttack: " + boss.Attack);




            if (healthCode.gHealth < 0)
            {
                Debug.Log("asasd");
                healthCode.gHealth = 0;
                healthCode.ggHealth = "Health: " + healthCode.gHealth;

                Lost = "You Lost";


            }
            if (boss.Health < 0)
            {
                boss.Health = 0;
                boss.demon = ("Demon \nHealth: " + boss.Health + "\nDefense: " + boss.Defense + "\nAttack: " + boss.Attack);

                Lost = "You Won";
            }

        }




        GUI.Box(new Rect(476, 610, 456, 97), "");
        GUI.Label(new Rect(476, 610, 456, 97), Lost, style);

        GUI.Label(new Rect(107, 401, 319, 146), healthCode.hatdog);
    }

}
