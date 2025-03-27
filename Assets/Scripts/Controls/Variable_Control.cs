using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable_Control : MonoBehaviour
{
    //List of variables kept for game
    public float money = 0;
    public float conveyerSpeed = 5;

    //Price of unlocks
    public float unlock_cost_1 = 1;
    public float unlock_cost_2 = 1;
    public float unlock_cost_3 = 1;
    public float unlock_cost_4 = 1;
    public float unlock_cost_5 = 1;

    public float unlock_cost_6 = 1;
    public float unlock_cost_7 = 1;
    public float unlock_cost_8 = 1;
    public float unlock_cost_9 = 1;
    public float unlock_cost_10 = 1;
    public float unlock_cost_11 = 1;

    //GameObjects to be dragged in
    public GameObject dropper_0_Unlock_Sprite_1;
    public GameObject dropper_0_Unlock_Sprite_2;
    public GameObject dropper_0_Unlock_Sprite_3;
    public GameObject dropper_0_Unlock_Sprite_4;
    public GameObject dropper_0_Unlock_Sprite_5;
    public GameObject dropper_0_Unlock_Sprite_6;
    public GameObject dropper_0_Unlock_Sprite_7;
    public GameObject dropper_0_Unlock_Sprite_8;
    public GameObject dropper_0_Unlock_Sprite_9;
    public GameObject dropper_0_Unlock_Sprite_10;
    public GameObject dropper_0_Unlock_Sprite_11;

    public GameObject dropper_1_Unlock_Sprite_1;
    public GameObject dropper_1_Unlock_Sprite_2;
    public GameObject dropper_1_Unlock_Sprite_3;
    public GameObject dropper_1_Unlock_Sprite_4;
    public GameObject dropper_1_Unlock_Sprite_5;
    public GameObject dropper_1_Unlock_Sprite_6;
    public GameObject dropper_1_Unlock_Sprite_7;
    public GameObject dropper_1_Unlock_Sprite_8;
    public GameObject dropper_1_Unlock_Sprite_9;
    public GameObject dropper_1_Unlock_Sprite_10;
    public GameObject dropper_1_Unlock_Sprite_11;

    public GameObject dropper_2_Unlock_Sprite_1;
    public GameObject dropper_2_Unlock_Sprite_2;
    public GameObject dropper_2_Unlock_Sprite_3;
    public GameObject dropper_2_Unlock_Sprite_4;
    public GameObject dropper_2_Unlock_Sprite_5;
    public GameObject dropper_2_Unlock_Sprite_6;
    public GameObject dropper_2_Unlock_Sprite_7;
    public GameObject dropper_2_Unlock_Sprite_8;
    public GameObject dropper_2_Unlock_Sprite_9;
    public GameObject dropper_2_Unlock_Sprite_10;
    public GameObject dropper_2_Unlock_Sprite_11;

    public GameObject dropper_3_Unlock_Sprite_1;
    public GameObject dropper_3_Unlock_Sprite_2;
    public GameObject dropper_3_Unlock_Sprite_3;
    public GameObject dropper_3_Unlock_Sprite_4;
    public GameObject dropper_3_Unlock_Sprite_5;
    public GameObject dropper_3_Unlock_Sprite_6;
    public GameObject dropper_3_Unlock_Sprite_7;
    public GameObject dropper_3_Unlock_Sprite_8;
    public GameObject dropper_3_Unlock_Sprite_9;
    public GameObject dropper_3_Unlock_Sprite_10;
    public GameObject dropper_3_Unlock_Sprite_11;

    public GameObject dropper_4_Unlock_Sprite_1;
    public GameObject dropper_4_Unlock_Sprite_2;
    public GameObject dropper_4_Unlock_Sprite_3;
    public GameObject dropper_4_Unlock_Sprite_4;
    public GameObject dropper_4_Unlock_Sprite_5;
    public GameObject dropper_4_Unlock_Sprite_6;
    public GameObject dropper_4_Unlock_Sprite_7;
    public GameObject dropper_4_Unlock_Sprite_8;
    public GameObject dropper_4_Unlock_Sprite_9;
    public GameObject dropper_4_Unlock_Sprite_10;
    public GameObject dropper_4_Unlock_Sprite_11;

    public GameObject dropper_5_Unlock_Sprite_1;
    public GameObject dropper_5_Unlock_Sprite_2;
    public GameObject dropper_5_Unlock_Sprite_3;
    public GameObject dropper_5_Unlock_Sprite_4;
    public GameObject dropper_5_Unlock_Sprite_5;
    public GameObject dropper_5_Unlock_Sprite_6;
    public GameObject dropper_5_Unlock_Sprite_7;
    public GameObject dropper_5_Unlock_Sprite_8;
    public GameObject dropper_5_Unlock_Sprite_9;
    public GameObject dropper_5_Unlock_Sprite_10;
    public GameObject dropper_5_Unlock_Sprite_11;

    private void Start()
    {
        dropper_0_Unlock_Sprite_1.GetComponent<Lock>().cost = unlock_cost_1;
        dropper_1_Unlock_Sprite_1.GetComponent<Lock>().cost = unlock_cost_1;
        dropper_2_Unlock_Sprite_1.GetComponent<Lock>().cost = unlock_cost_1;
        dropper_3_Unlock_Sprite_1.GetComponent<Lock>().cost = unlock_cost_1;
        dropper_4_Unlock_Sprite_1.GetComponent<Lock>().cost = unlock_cost_1;
        dropper_5_Unlock_Sprite_1.GetComponent<Lock>().cost = unlock_cost_1;

        dropper_0_Unlock_Sprite_2.GetComponent<Lock>().cost = unlock_cost_2;
        dropper_1_Unlock_Sprite_2.GetComponent<Lock>().cost = unlock_cost_2;
        dropper_2_Unlock_Sprite_2.GetComponent<Lock>().cost = unlock_cost_2;
        dropper_3_Unlock_Sprite_2.GetComponent<Lock>().cost = unlock_cost_2;
        dropper_4_Unlock_Sprite_2.GetComponent<Lock>().cost = unlock_cost_2;
        dropper_5_Unlock_Sprite_2.GetComponent<Lock>().cost = unlock_cost_2;

        dropper_0_Unlock_Sprite_3.GetComponent<Lock>().cost = unlock_cost_3;
        dropper_1_Unlock_Sprite_3.GetComponent<Lock>().cost = unlock_cost_3;
        dropper_2_Unlock_Sprite_3.GetComponent<Lock>().cost = unlock_cost_3;
        dropper_3_Unlock_Sprite_3.GetComponent<Lock>().cost = unlock_cost_3;
        dropper_4_Unlock_Sprite_3.GetComponent<Lock>().cost = unlock_cost_3;
        dropper_5_Unlock_Sprite_3.GetComponent<Lock>().cost = unlock_cost_3;

        dropper_0_Unlock_Sprite_4.GetComponent<Lock>().cost = unlock_cost_4;
        dropper_1_Unlock_Sprite_4.GetComponent<Lock>().cost = unlock_cost_4;
        dropper_2_Unlock_Sprite_4.GetComponent<Lock>().cost = unlock_cost_4;
        dropper_3_Unlock_Sprite_4.GetComponent<Lock>().cost = unlock_cost_4;
        dropper_4_Unlock_Sprite_4.GetComponent<Lock>().cost = unlock_cost_4;
        dropper_5_Unlock_Sprite_4.GetComponent<Lock>().cost = unlock_cost_4;

        dropper_0_Unlock_Sprite_5.GetComponent<Lock>().cost = unlock_cost_5;
        dropper_1_Unlock_Sprite_5.GetComponent<Lock>().cost = unlock_cost_5;
        dropper_2_Unlock_Sprite_5.GetComponent<Lock>().cost = unlock_cost_5;
        dropper_3_Unlock_Sprite_5.GetComponent<Lock>().cost = unlock_cost_5;
        dropper_4_Unlock_Sprite_5.GetComponent<Lock>().cost = unlock_cost_5;
        dropper_5_Unlock_Sprite_5.GetComponent<Lock>().cost = unlock_cost_5;

        dropper_0_Unlock_Sprite_6.GetComponent<Lock>().cost = unlock_cost_6;
        dropper_1_Unlock_Sprite_6.GetComponent<Lock>().cost = unlock_cost_6;
        dropper_2_Unlock_Sprite_6.GetComponent<Lock>().cost = unlock_cost_6;
        dropper_3_Unlock_Sprite_6.GetComponent<Lock>().cost = unlock_cost_6;
        dropper_4_Unlock_Sprite_6.GetComponent<Lock>().cost = unlock_cost_6;
        dropper_5_Unlock_Sprite_6.GetComponent<Lock>().cost = unlock_cost_6;

        dropper_0_Unlock_Sprite_7.GetComponent<Lock>().cost = unlock_cost_7;
        dropper_1_Unlock_Sprite_7.GetComponent<Lock>().cost = unlock_cost_7;
        dropper_2_Unlock_Sprite_7.GetComponent<Lock>().cost = unlock_cost_7;
        dropper_3_Unlock_Sprite_7.GetComponent<Lock>().cost = unlock_cost_7;
        dropper_4_Unlock_Sprite_7.GetComponent<Lock>().cost = unlock_cost_7;
        dropper_5_Unlock_Sprite_7.GetComponent<Lock>().cost = unlock_cost_7;

        dropper_0_Unlock_Sprite_8.GetComponent<Lock>().cost = unlock_cost_8;
        dropper_1_Unlock_Sprite_8.GetComponent<Lock>().cost = unlock_cost_8;
        dropper_2_Unlock_Sprite_8.GetComponent<Lock>().cost = unlock_cost_8;
        dropper_3_Unlock_Sprite_8.GetComponent<Lock>().cost = unlock_cost_8;
        dropper_4_Unlock_Sprite_8.GetComponent<Lock>().cost = unlock_cost_8;
        dropper_5_Unlock_Sprite_8.GetComponent<Lock>().cost = unlock_cost_8;

        dropper_0_Unlock_Sprite_9.GetComponent<Lock>().cost = unlock_cost_9;
        dropper_1_Unlock_Sprite_9.GetComponent<Lock>().cost = unlock_cost_9;
        dropper_2_Unlock_Sprite_9.GetComponent<Lock>().cost = unlock_cost_9;
        dropper_3_Unlock_Sprite_9.GetComponent<Lock>().cost = unlock_cost_9;
        dropper_4_Unlock_Sprite_9.GetComponent<Lock>().cost = unlock_cost_9;
        dropper_5_Unlock_Sprite_9.GetComponent<Lock>().cost = unlock_cost_9;

        dropper_0_Unlock_Sprite_10.GetComponent<Lock>().cost = unlock_cost_10;
        dropper_1_Unlock_Sprite_10.GetComponent<Lock>().cost = unlock_cost_10;
        dropper_2_Unlock_Sprite_10.GetComponent<Lock>().cost = unlock_cost_10;
        dropper_3_Unlock_Sprite_10.GetComponent<Lock>().cost = unlock_cost_10;
        dropper_4_Unlock_Sprite_10.GetComponent<Lock>().cost = unlock_cost_10;
        dropper_5_Unlock_Sprite_10.GetComponent<Lock>().cost = unlock_cost_10;

        dropper_0_Unlock_Sprite_11.GetComponent<Lock>().cost = unlock_cost_11;
        dropper_1_Unlock_Sprite_11.GetComponent<Lock>().cost = unlock_cost_11;
        dropper_2_Unlock_Sprite_11.GetComponent<Lock>().cost = unlock_cost_11;
        dropper_3_Unlock_Sprite_11.GetComponent<Lock>().cost = unlock_cost_11;
        dropper_4_Unlock_Sprite_11.GetComponent<Lock>().cost = unlock_cost_11;
        dropper_5_Unlock_Sprite_11.GetComponent<Lock>().cost = unlock_cost_11;

    }
}
