using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprite_Page_Control : MonoBehaviour
{
    public GameObject SelectionWindow0;
    public GameObject SelectionWindow1;
    public GameObject SelectionWindow2;
    public GameObject SelectionWindow3;
    public GameObject SelectionWindow4;
    public GameObject SelectionWindow5;
    public GameObject SelectionWindow6;
    public GameObject SelectionWindow7;
    public GameObject SelectionWindow8;
    public GameObject SelectionWindow9;
    public GameObject SelectionWindow10;
    public GameObject SelectionWindow11;

    Sprite_Control spriteControl;
    Variable_Control variableControl;
    Text_Control textControl;

    public GameObject orbGameObject;
    SpriteRenderer orbRenderer;
    public bool isUnlockedOrb1 = false;
    public bool isUnlockedOrb2 = false;
    public bool isUnlockedOrb3 = false;
    public bool isUnlockedOrb4 = false;
    public bool isUnlockedOrb5 = false;
    public bool isUnlockedOrb6 = false;
    public bool isUnlockedOrb7 = false;
    public bool isUnlockedOrb8 = false;
    public bool isUnlockedOrb9 = false;
    public bool isUnlockedOrb10 = false;
    public bool isUnlockedOrb11 = false;

    private void Start()
    {
        orbRenderer = orbGameObject.GetComponent<SpriteRenderer>();
        orbRenderer.color = orbGameObject.GetComponent<Orbs>().orbColor;
        spriteControl = GameObject.Find("Main_Control").GetComponent<Sprite_Control>();
        variableControl = GameObject.Find("Main_Control").GetComponent<Variable_Control>();
        textControl = GameObject.Find("Main_Control").GetComponent<Text_Control>();
    }
    public void turnOffSelections()
    {
        foreach (Transform child in SelectionWindow0.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow1.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow2.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow3.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow4.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow5.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow6.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow7.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow8.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow9.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow10.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        foreach (Transform child in SelectionWindow11.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
    }
    public void unlockOrb1()
    {
        isUnlockedOrb1 = true;
        variableControl.money -= variableControl.unlock_cost_1;
        textControl.updateMoney();
    }
    public void unlockOrb2()
    {
        isUnlockedOrb2 = true;
        variableControl.money -= variableControl.unlock_cost_2;
        textControl.updateMoney();
    }
    public void unlockOrb3()
    {
        isUnlockedOrb3 = true;
        variableControl.money -= variableControl.unlock_cost_3;
        textControl.updateMoney();
    }
    public void unlockOrb4()
    {
        isUnlockedOrb4 = true;
        variableControl.money -= variableControl.unlock_cost_4;
        textControl.updateMoney();
    }
    public void unlockOrb5()
    {
        isUnlockedOrb5 = true;
        variableControl.money -= variableControl.unlock_cost_5;
        textControl.updateMoney();
    }
    public void unlockOrb6()
    {
        isUnlockedOrb6 = true;
        variableControl.money -= variableControl.unlock_cost_6;
        textControl.updateMoney();
    }
    public void unlockOrb7()
    {
        isUnlockedOrb7 = true;
        variableControl.money -= variableControl.unlock_cost_7;
        textControl.updateMoney();
    }
    public void unlockOrb8()
    {
        isUnlockedOrb8 = true;
        variableControl.money -= variableControl.unlock_cost_8;
        textControl.updateMoney();
    }
    public void unlockOrb9()
    {
        isUnlockedOrb9 = true;
        variableControl.money -= variableControl.unlock_cost_9;
        textControl.updateMoney();
    }
    public void unlockOrb10()
    {
        isUnlockedOrb10 = true;
        variableControl.money -= variableControl.unlock_cost_10;
        textControl.updateMoney();
    }
    public void unlockOrb11()
    {
        isUnlockedOrb11 = true;
        variableControl.money -= variableControl.unlock_cost_11;
        textControl.updateMoney();
    }

    public void selectOrb0()
    {
        spriteControl.setToOrb0(orbRenderer);
    }
    public void selectOrb1()
    {
        if(isUnlockedOrb1)
        {
            spriteControl.setToOrb1(orbRenderer);
        }
    }
    public void selectOrb2()
    {
        if (isUnlockedOrb2)
        {
            spriteControl.setToOrb2(orbRenderer);
        }
    }
    public void selectOrb3()
    {
        if (isUnlockedOrb3)
        {
            spriteControl.setToOrb3(orbRenderer);
        }
    }
    public void selectOrb4()
    {
        if (isUnlockedOrb4)
        {
            spriteControl.setToOrb4(orbRenderer);
        }
    }
    public void selectOrb5()
    {
        if (isUnlockedOrb5)
        {
            spriteControl.setToOrb5(orbRenderer);
        }
    }
    public void selectOrb6()
    {
        if (isUnlockedOrb6)
        {
            spriteControl.setToOrb6(orbRenderer);
        }
    }
    public void selectOrb7()
    {
        if (isUnlockedOrb7)
        {
            spriteControl.setToOrb7(orbRenderer);
        }
    }
    public void selectOrb8()
    {
        if (isUnlockedOrb8)
        {
            spriteControl.setToOrb8(orbRenderer);
        }
    }
    public void selectOrb9()
    {
        if (isUnlockedOrb9)
        {
            spriteControl.setToOrb9(orbRenderer);
        }
    }
    public void selectOrb10()
    {
        if (isUnlockedOrb10)
        {
            spriteControl.setToOrb10(orbRenderer);
        }
    }
    public void selectOrb11()
    {
        if (isUnlockedOrb11)
        {
            spriteControl.setToOrb11(orbRenderer);
        }
    }
}
