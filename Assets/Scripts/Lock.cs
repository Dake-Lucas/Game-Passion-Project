using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] public float cost;
    public Sprite_Page_Control spritePageControl;
    [SerializeField] public int lockNum;
    Variable_Control variableControl;
    Sprite_Control spriteControl;
    public Sprite Locked_Sprite;
    public Sprite Unlocked_Sprite;
    public GameObject selectionOutline;
    Selection_Outline selectionOutlineScript;
    Color baseColor;
    UnityEngine.UI.Image image;
    private void Start()
    {
        selectionOutlineScript = selectionOutline.GetComponent<Selection_Outline>();
        variableControl = GameObject.Find("Main_Control").GetComponent<Variable_Control>();
        spriteControl = GameObject.Find("Main_Control").GetComponent<Sprite_Control>();
        image = GetComponent<UnityEngine.UI.Image>();
        baseColor = image.color;
        if (lockNum == 1)
        {
            cost = variableControl.unlock_cost_1;
        }
        else if (lockNum == 2)
        {
            cost = variableControl.unlock_cost_2;
        }
        else if (lockNum == 3)
        {
            cost = variableControl.unlock_cost_3;
        }
        else if (lockNum == 4)
        {
            cost = variableControl.unlock_cost_4;
        }
        else if (lockNum == 5)
        {
            cost = variableControl.unlock_cost_5;
        }
        else if (lockNum == 6)
        {
            cost = variableControl.unlock_cost_6;
        }
        else if (lockNum == 7)
        {
            cost = variableControl.unlock_cost_7;
        }
        else if (lockNum == 8)
        {
            cost = variableControl.unlock_cost_8;
        }
        else if (lockNum == 9)
        {
            cost = variableControl.unlock_cost_9;
        }
        else if (lockNum == 10)
        {
            cost = variableControl.unlock_cost_10;
        }
        else if (lockNum == 11)
        {
            cost = variableControl.unlock_cost_11;
        }
    }
    void Update()
    {
        if(IsMouseOverUIElement())
        {
            if(variableControl.money >= cost)
            {
                if (image.sprite == Locked_Sprite)
                {
                    image.sprite = Unlocked_Sprite;
                }
            }
            else
            {
                image.color = Color.red;
            }
        }
        else
        {
            if(image.color == Color.red)
            {
                image.color = baseColor;
            }
            else
            {
                if (image.sprite == Unlocked_Sprite)
                {
                    image.sprite = Locked_Sprite;
                }
            }
        }
    }
    private bool IsMouseOverUIElement()
    {
        Collider2D collider = GetComponent<Collider2D>();
        RectTransform rectTransform = GetComponent<RectTransform>();
        if(collider == Physics2D.OverlapPoint(Input.mousePosition))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void lockButtonPressed()
    {
        if(variableControl.money >= cost)
        {
            if(lockNum == 1)
            {
                spritePageControl.unlockOrb1();
            }
            else if(lockNum == 2)
            {
                spritePageControl.unlockOrb2();
            }
            else if (lockNum == 3)
            {
                spritePageControl.unlockOrb3();
            }
            else if (lockNum == 4)
            {
                spritePageControl.unlockOrb4();
            }
            else if (lockNum == 5)
            {
                spritePageControl.unlockOrb5();
            }
            else if (lockNum == 6)
            {
                spritePageControl.unlockOrb6();
            }
            else if (lockNum == 7)
            {
                spritePageControl.unlockOrb7();
            }
            else if (lockNum == 8)
            {
                spritePageControl.unlockOrb8();
            }
            else if (lockNum == 9)
            {
                spritePageControl.unlockOrb9();
            }
            else if (lockNum == 10)
            {
                spritePageControl.unlockOrb10();
            }
            else if (lockNum == 11)
            {
                spritePageControl.unlockOrb11();
            }
            else
            {
                Debug.Log("Lock Num Out of Bounds");
            }
            selectionOutlineScript.changeActiveStatus();
            selectionOutlineScript.isActive = true;
            Destroy(gameObject);
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }

}
