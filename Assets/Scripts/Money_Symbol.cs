using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_Symbol : MonoBehaviour
{
    UnityEngine.UI.Image image;
    float fadeSpeed = 3;
    private void Start()
    {
        image = GetComponent<UnityEngine.UI.Image>();
    }
    void Update()
    {
        image.color = new Color(image.color.r,image.color.g,image.color.b,image.color.a-(fadeSpeed*Time.deltaTime));
    }
}
