using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next_Page_Button : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public void changePage()
    {
        if(!page1.activeSelf)
        {
            page1.SetActive(true);
            page2.SetActive(false);
        }
        else
        {
            page1.SetActive(false);
            page2.SetActive(true);
        }
    }
}
