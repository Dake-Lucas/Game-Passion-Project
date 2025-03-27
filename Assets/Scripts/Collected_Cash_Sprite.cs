using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected_Cash_Sprite : MonoBehaviour
{
    SpriteRenderer image;
    [SerializeField] float fadeSpeed;
    [SerializeField] float floatSpeed;
    private void Start()
    {
        image = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(image.color.a > 0)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a - (fadeSpeed * Time.deltaTime));
            gameObject.transform.position += new Vector3(0, floatSpeed * Time.deltaTime, 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
