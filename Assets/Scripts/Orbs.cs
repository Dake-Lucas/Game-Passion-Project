using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Orbs : MonoBehaviour
{
    public GameObject cashOnDeath;
    bool onConveyer = false;
    public float conveyerSpeed;
    public Color orbColor;
    public float fallSpeed;
    float rotatexSpeed = 300;
    float rotateySpeed = 100;
    float rotatezSpeed = -1000;
    float randLownum;
    float randHighnum;
    public float collectionValue;
    Variable_Control variableControl;
    Sound_Control soundControl;
    Text_Control textControl;
    private void Start()
    {
        rotatexSpeed *= fallSpeed;
        rotateySpeed *= fallSpeed;
        variableControl = GameObject.Find("Main_Control").GetComponent<Variable_Control>();
        soundControl = GameObject.Find("Main_Control").GetComponent<Sound_Control>();
        textControl = GameObject.Find("Main_Control").GetComponent<Text_Control>();
        conveyerSpeed = variableControl.conveyerSpeed;
    }
    void Update()
    {
        if(!onConveyer)
        {
            this.transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
            this.transform.Rotate(0, 0, (rotatezSpeed / fallSpeed) * Time.deltaTime);
        }
        else
        {
            this.transform.position += new Vector3(conveyerSpeed*Time.deltaTime, 0, 0);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collector"))
        {
            variableControl.money += collectionValue;
            textControl.updateMoney();
            soundControl.playButtonUpgradeSound();
            Debug.Log("Sound Played");
            Instantiate(cashOnDeath);
            Destroy(gameObject);
        }
        if(collision.CompareTag("Conveyer"))
        {
            onConveyer = true;
        }
    }
}