using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Selection_Outline : MonoBehaviour
{
    public bool isActive = false;
    public GameObject pageControl;
    Sprite_Page_Control spritePageControl;
    Variable_Control variableControl;
    public GameObject outline;
    private void Start()
    {
        spritePageControl = pageControl.GetComponent<Sprite_Page_Control>();
    }
    public void changeActiveStatus()
    {
        outline.SetActive(!gameObject.activeSelf);
    }
    public void changeToGreen()
    {
        if(isActive)
        {
            spritePageControl.turnOffSelections();
            foreach (Transform child in outline.transform)
            {
                child.GetComponent<Image>().color = Color.green;
            }
        }
    }
}