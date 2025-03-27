using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Input_Control : MonoBehaviour
{
    public GraphicRaycaster graphicRaycaster;
    Button_Control buttonControl;
    private void Start()
    {
        buttonControl = GetComponent<Button_Control>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Button Pressed");
            buttonControl.closeAllWindows();
        }
        if(Input.GetMouseButtonDown(0))
        {
            if(isRaycastEmpty())
            {
                buttonControl.closeAllWindows();
            }
        }
    }
    public bool isRaycastEmpty()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition
        };
        List<RaycastResult> results = new List<RaycastResult>();
        graphicRaycaster.Raycast(pointerData, results);

        return results.Count == 0;
    }
}
