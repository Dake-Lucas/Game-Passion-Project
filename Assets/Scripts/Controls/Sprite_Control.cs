using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprite_Control : MonoBehaviour
{
    //Sprites
    public Sprite orb0;
    public Sprite orb1;
    public Sprite orb2;
    public Sprite orb3;
    public Sprite orb4;
    public Sprite orb5;
    public Sprite orb6;
    public Sprite orb7;
    public Sprite orb8;
    public Sprite orb9;
    public Sprite orb10;
    public Sprite orb11;

    public GameObject Low_Money_Symbol;
    UnityEngine.UI.Image lowMoneySprite;

    public GameObject orb_for_dropper_0;
    public GameObject orb_for_dropper_1;
    public GameObject orb_for_dropper_2;
    public GameObject orb_for_dropper_3;
    public GameObject orb_for_dropper_4;
    public GameObject orb_for_dropper_5;

    SpriteRenderer sprite_renderer_dropper_0_orb;
    SpriteRenderer sprite_renderer_dropper_1_orb;
    SpriteRenderer sprite_renderer_dropper_2_orb;
    SpriteRenderer sprite_renderer_dropper_3_orb;
    SpriteRenderer sprite_renderer_dropper_4_orb;
    SpriteRenderer sprite_renderer_dropper_5_orb;

    public void Start()
    {
        sprite_renderer_dropper_0_orb = orb_for_dropper_0.GetComponent<SpriteRenderer>();
        sprite_renderer_dropper_1_orb = orb_for_dropper_1.GetComponent<SpriteRenderer>();
        sprite_renderer_dropper_2_orb = orb_for_dropper_2.GetComponent<SpriteRenderer>();
        sprite_renderer_dropper_3_orb = orb_for_dropper_3.GetComponent<SpriteRenderer>();
        sprite_renderer_dropper_4_orb = orb_for_dropper_4.GetComponent<SpriteRenderer>();
        sprite_renderer_dropper_5_orb = orb_for_dropper_5.GetComponent<SpriteRenderer>();

        lowMoneySprite = Low_Money_Symbol.GetComponent<UnityEngine.UI.Image>();

        //Initializing default sprite for all the droppers
        sprite_renderer_dropper_0_orb.sprite = orb0;
        sprite_renderer_dropper_1_orb.sprite = orb0;
        sprite_renderer_dropper_2_orb.sprite = orb0;
        sprite_renderer_dropper_3_orb.sprite = orb0;
        sprite_renderer_dropper_4_orb.sprite = orb0;
        sprite_renderer_dropper_5_orb.sprite = orb0;
    }
    public void LowMoneySymbolActivation()
    {
        lowMoneySprite.color = new Color(lowMoneySprite.color.r, lowMoneySprite.color.g, lowMoneySprite.color.b, 1);
    }
    public void setToOrb0(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb0;
        dropperOrb.color = dropperOrb.GetComponent<Orbs>().orbColor;
    }
    public void setToOrb1(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb1;
        dropperOrb.color = dropperOrb.GetComponent<Orbs>().orbColor;
    }
    public void setToOrb2(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb2;
        dropperOrb.color = dropperOrb.GetComponent<Orbs>().orbColor;
    }
    public void setToOrb3(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb3;
        dropperOrb.color = dropperOrb.GetComponent<Orbs>().orbColor;
    }
    public void setToOrb4(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb4;
        dropperOrb.color = dropperOrb.GetComponent<Orbs>().orbColor;
    }
    public void setToOrb5(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb5;
        dropperOrb.color = dropperOrb.GetComponent<Orbs>().orbColor;
    }
    public void setToOrb6(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb6;
        dropperOrb.color = Color.white;
    }
    public void setToOrb7(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb7;
        dropperOrb.color = Color.white;
    }
    public void setToOrb8(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb8;
        dropperOrb.color = Color.white;
    }
    public void setToOrb9(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb9;
        dropperOrb.color = Color.white;
    }
    public void setToOrb10(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb10;
        dropperOrb.color = Color.white;
    }
    public void setToOrb11(SpriteRenderer dropperOrb)
    {
        dropperOrb.sprite = orb11;
        dropperOrb.color = Color.white;
    }
}
