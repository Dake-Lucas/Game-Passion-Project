using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper_Control : MonoBehaviour
{
    //Droppers
    public GameObject dropper_0_body;
    public GameObject dropper_1_body;
    public GameObject dropper_2_body;
    public GameObject dropper_3_body;
    public GameObject dropper_4_body;
    public GameObject dropper_5_body;

    Dropper dropper_0;
    Dropper dropper_1;
    Dropper dropper_2;
    Dropper dropper_3;
    Dropper dropper_4;
    Dropper dropper_5;

    private void Start()
    {
        dropper_0 = dropper_0_body.GetComponent<Dropper>();
        dropper_1 = dropper_1_body.GetComponent<Dropper>();
        dropper_2 = dropper_2_body.GetComponent<Dropper>();
        dropper_3 = dropper_3_body.GetComponent<Dropper>();
        dropper_4 = dropper_4_body.GetComponent<Dropper>();
        dropper_5 = dropper_5_body.GetComponent<Dropper>();
    }
    IEnumerator dropper_1_dropping()
    {
        while(true)
        {
            yield return new WaitForSeconds(dropper_1.dropperCooldownTime);
            dropper_1.dropOrbForOtherDroppers();
        }
    }
    IEnumerator dropper_2_dropping()
    {
        while (true)
        {
            yield return new WaitForSeconds(dropper_2.dropperCooldownTime);
            dropper_2.dropOrbForOtherDroppers();
        }
    }
    IEnumerator dropper_3_dropping()
    {
        while (true)
        {
            yield return new WaitForSeconds(dropper_3.dropperCooldownTime);
            dropper_3.dropOrbForOtherDroppers();
        }
    }
    IEnumerator dropper_4_dropping()
    {
        while (true)
        {
            yield return new WaitForSeconds(dropper_4.dropperCooldownTime);
            dropper_4.dropOrbForOtherDroppers();
        }
    }
    IEnumerator dropper_5_dropping()
    {
        while (true)
        {
            yield return new WaitForSeconds(dropper_5.dropperCooldownTime);
            dropper_5.dropOrbForOtherDroppers();
        }
    }
    public void startDropperOne()
    {
        StartCoroutine("dropper_1_dropping");
    }
    public void startDropperTwo()
    {
        StartCoroutine("dropper_2_dropping");
    }
    public void startDropperThree()
    {
        StartCoroutine("dropper_3_dropping");
    }
    public void startDropperFour()
    {
        StartCoroutine("dropper_4_dropping");
    }
    public void startDropperFive()
    {
        StartCoroutine("dropper_5_dropping");
    }
}
