using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Button_Control : MonoBehaviour
{
    //List of Booleans
    bool isGamePaused = false;
    //End of bool List

    //List of all components dragged from main scene
    public GameObject upgradePanelDropper0;
    public GameObject upgradePanelDropper1;
    public GameObject upgradePanelDropper2;
    public GameObject upgradePanelDropper3;
    public GameObject upgradePanelDropper4;
    public GameObject upgradePanelDropper5;

    public GameObject dropper_0_body;
    public GameObject dropper_1_body;
    public GameObject dropper_2_body;
    public GameObject dropper_3_body;
    public GameObject dropper_4_body;
    public GameObject dropper_5_body;

    public GameObject unlockButtonOne;
    public GameObject unlockButtonTwo;
    public GameObject unlockButtonThree;
    public GameObject unlockButtonFour;
    public GameObject unlockButtonFive;


    public GameObject spritesPanel0_Page1;
    public GameObject spritesPanel0_Page2;

    public GameObject spritesPanel1_Page1;
    public GameObject spritesPanel1_Page2;

    public GameObject spritesPanel2_Page1;
    public GameObject spritesPanel2_Page2;

    public GameObject spritesPanel3_Page1;
    public GameObject spritesPanel3_Page2;

    public GameObject spritesPanel4_Page1;
    public GameObject spritesPanel4_Page2;

    public GameObject spritesPanel5_Page1;
    public GameObject spritesPanel5_Page2;

    //Dropper Scripts
    Dropper dropper_0;
    Dropper dropper_1;
    Dropper dropper_2;
    Dropper dropper_3;
    Dropper dropper_4;
    Dropper dropper_5;

    //List of Controls
    Variable_Control variableControl;
    Text_Control textControl;
    Sound_Control soundControl;
    Dropper_Control dropperControl;
    Sprite_Control spriteControl;

    //Other variables
    float tempTimeScale;
    //End of variable list

    private void Start()
    {
        //Assign Controls
        variableControl = GetComponent<Variable_Control>();
        textControl = GetComponent<Text_Control>();
        soundControl = GetComponent<Sound_Control>();
        dropperControl = GetComponent<Dropper_Control>();
        spriteControl = GetComponent<Sprite_Control>();

        //Assign Dropper Scripts
        dropper_0 = dropper_0_body.GetComponent<Dropper>();
        dropper_1 = dropper_1_body.GetComponent<Dropper>();
        dropper_2 = dropper_2_body.GetComponent<Dropper>();
        dropper_3 = dropper_3_body.GetComponent<Dropper>();
        dropper_4 = dropper_4_body.GetComponent<Dropper>();
        dropper_5 = dropper_5_body.GetComponent<Dropper>();
    }
    //Method for when the pause button is pressed to set the timeScale to 0, will also unpause if the game is already paused
    public void PauseButtonPressed()
    {
        if (isGamePaused == false)
        {
            tempTimeScale = Time.timeScale;
            Debug.Log("Time Scale: " + tempTimeScale);
            PauseGame();
            isGamePaused = true;
        }
        else
        {
            UnpauseGame();
            isGamePaused = false;
        }
    }
    //Sets timescale to 0, effectively stopping things that run with time from running
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    //Sets the timescale to what it was before it was paused
    public void UnpauseGame()
    {
        Time.timeScale = tempTimeScale;
    }
    //Method for adding then updating money
    public void addMoney(int amountMoney)
    {
        variableControl.money += amountMoney;
        textControl.updateMoney();
    }


    //Window Control
    public void closeAllWindows()
    {
        upgradePanelDropper0.SetActive(false);
        upgradePanelDropper1.SetActive(false);
        upgradePanelDropper2.SetActive(false);
        upgradePanelDropper3.SetActive(false);
        upgradePanelDropper4.SetActive(false);
        upgradePanelDropper5.SetActive(false);

        spritesPanel0_Page1.SetActive(false);
        spritesPanel1_Page1.SetActive(false);
        spritesPanel2_Page1.SetActive(false);
        spritesPanel3_Page1.SetActive(false);
        spritesPanel4_Page1.SetActive(false);
        spritesPanel5_Page1.SetActive(false);

        spritesPanel0_Page2.SetActive(false);
        spritesPanel1_Page2.SetActive(false);
        spritesPanel2_Page2.SetActive(false);
        spritesPanel3_Page2.SetActive(false);
        spritesPanel4_Page2.SetActive(false);
        spritesPanel5_Page2.SetActive(false);
    }

    public void openCloseSpritePanel0()
    {
        spritesPanel0_Page1.SetActive(!spritesPanel0_Page1.activeSelf && !spritesPanel0_Page2.activeSelf);
        spritesPanel0_Page2.SetActive(false);
    }
    public void openCloseSpritePanel1()
    {
        spritesPanel1_Page1.SetActive(!spritesPanel1_Page1.activeSelf && !spritesPanel1_Page2.activeSelf);
        spritesPanel1_Page2.SetActive(false);
    }
    public void openCloseSpritePanel2()
    {
        spritesPanel2_Page1.SetActive(!spritesPanel2_Page1.activeSelf && !spritesPanel2_Page2.activeSelf);
        spritesPanel2_Page2.SetActive(false);
    }
    public void openCloseSpritePanel3()
    {
        spritesPanel3_Page1.SetActive(!spritesPanel3_Page1.activeSelf && !spritesPanel3_Page2.activeSelf);
        spritesPanel3_Page2.SetActive(false);
    }
    public void openCloseSpritePanel4()
    {
        spritesPanel4_Page1.SetActive(!spritesPanel4_Page1.activeSelf && !spritesPanel4_Page2.activeSelf);
        spritesPanel4_Page2.SetActive(false);
    }
    public void openCloseSpritePanel5()
    {
        spritesPanel5_Page1.SetActive(!spritesPanel5_Page1.activeSelf && !spritesPanel5_Page2.activeSelf);
        spritesPanel5_Page2.SetActive(false);
    }

    //Upgrade Droppers Menus
    public void openCloseDropperZeroMenu()
    {
        if (!upgradePanelDropper0.activeSelf)
        {
            closeAllWindows();
            upgradePanelDropper0.SetActive(true);
        }
        else
        {
            upgradePanelDropper0.SetActive(false);
        }
    }
    public void openCloseDropperOneMenu()
    {
        if (!upgradePanelDropper1.activeSelf)
        {
            closeAllWindows();
            upgradePanelDropper1.SetActive(true);
        }
        else
        {
            upgradePanelDropper1.SetActive(false);
        }
    }
    public void openCloseDropperTwoMenu()
    {
        if (!upgradePanelDropper2.activeSelf)
        {
            closeAllWindows();
            upgradePanelDropper2.SetActive(true);
        }
        else
        {
            upgradePanelDropper2.SetActive(false);
        }
    }
    public void openCloseDropperThreeMenu()
    {
        if (!upgradePanelDropper3.activeSelf)
        {
            closeAllWindows();
            upgradePanelDropper3.SetActive(true);
        }
        else
        {
            upgradePanelDropper3.SetActive(false);
        }
    }
    public void openCloseDropperFourMenu()
    {
        if (!upgradePanelDropper4.activeSelf)
        {
            closeAllWindows();
            upgradePanelDropper4.SetActive(true);
        }
        else
        {
            upgradePanelDropper4.SetActive(false);
        }
    }
    public void openCloseDropperFiveMenu()
    {
        if (!upgradePanelDropper5.activeSelf)
        {
            closeAllWindows();
            upgradePanelDropper5.SetActive(true);
        }
        else
        {
            upgradePanelDropper5.SetActive(false);
        }
    }
    //End of Upgrade Window Control

    //End of Window Control





    //Starts Dropper Couroutines if they have enough money
    public void startDropperOne()
    {
        if (variableControl.money >= dropper_1.unlockCost)
        {
            dropperControl.startDropperOne();
            variableControl.money -= dropper_1.unlockCost;
            textControl.updateMoney();
            Destroy(unlockButtonOne);
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    public void startDropperTwo()
    {

        if (variableControl.money >= dropper_2.unlockCost)
        {
            dropperControl.startDropperTwo();
            variableControl.money -= dropper_2.unlockCost;
            textControl.updateMoney();
            Destroy(unlockButtonTwo);
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    public void startDropperThree()
    {

        if (variableControl.money >= dropper_3.unlockCost)
        {
            dropperControl.startDropperThree();
            variableControl.money -= dropper_3.unlockCost;
            textControl.updateMoney();
            Destroy(unlockButtonThree);
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    public void startDropperFour()
    {

        if (variableControl.money >= dropper_4.unlockCost)
        {
            dropperControl.startDropperFour();
            variableControl.money -= dropper_4.unlockCost;
            textControl.updateMoney();
            Destroy(unlockButtonFour);
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    public void startDropperFive()
    {

        if (variableControl.money >= dropper_5.unlockCost)
        {
            dropperControl.startDropperFive();
            variableControl.money -= dropper_5.unlockCost;
            textControl.updateMoney();
            Destroy(unlockButtonFive);
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }





    //Button Upgrades
    //Upgrade Buttons Dropper 0
    public void upgradeDropperZeroDropSpeed()
    {
        if (variableControl.money >= dropper_0.orbSpeedUpgradePrice)
        {
            if (dropper_0.speedLevel < 20)
            {
                variableControl.money -= dropper_0.orbSpeedUpgradePrice;
                dropper_0.upgradeDropSpeed();
                textControl.updateDropperZeroDropSpeedButton();
                textControl.updateMoney();
            }
            else
            {
                textControl.DropperZeroDropSpeedText.text = "Upgrades\nComplete";
            }
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    public void upgradeDropperZeroOrbValue()
    {
        if (variableControl.money >= dropper_0.orbValueUpgradePrice)
        {
            variableControl.money -= dropper_0.orbValueUpgradePrice;
            dropper_0.upgradeOrbValue();
            textControl.updateDropperZeroOrbValueButton();
            textControl.updateMoney();
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }

    }
    //Upgrade Buttons Dropper 1
    public void upgradeDropperOneDropSpeed()
    {
        if (variableControl.money >= dropper_1.orbSpeedUpgradePrice)
        {
            if (dropper_1.speedLevel < 20)
            {
                variableControl.money -= dropper_1.orbSpeedUpgradePrice;
                dropper_1.upgradeDropSpeed();
                textControl.updateDropperOneDropSpeedButton();
                textControl.updateMoney();
            }
            else
            {
                textControl.DropperOneDropSpeedText.text = "Upgrades\nComplete";
            }
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    public void upgradeDropperOneOrbValue()
    {
        if (variableControl.money >= dropper_1.orbValueUpgradePrice)
        {
            variableControl.money -= dropper_1.orbValueUpgradePrice;
            dropper_1.upgradeOrbValue();
            textControl.updateDropperOneOrbValueButton();
            textControl.updateMoney();
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    //Upgrade Buttons Dropper 2
    public void upgradeDropperTwoDropSpeed()
    {
        if (variableControl.money >= dropper_2.orbSpeedUpgradePrice)
        {
            if (dropper_2.speedLevel < 20)
            {
                variableControl.money -= dropper_2.orbSpeedUpgradePrice;
                dropper_2.upgradeDropSpeed();
                textControl.updateDropperTwoDropSpeedButton();
                textControl.updateMoney();
            }
            else
            {
                textControl.DropperTwoDropSpeedText.text = "Upgrades\nComplete";
            }
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    public void upgradeDropperTwoOrbValue()
    {
        if (variableControl.money >= dropper_2.orbValueUpgradePrice)
        {
            variableControl.money -= dropper_2.orbValueUpgradePrice;
            dropper_2.upgradeOrbValue();
            textControl.updateDropperTwoOrbValueButton();
            textControl.updateMoney();
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    //Upgrade Buttons Dropper 3
    public void upgradeDropperThreeDropSpeed()
    {
        if (variableControl.money >= dropper_3.orbSpeedUpgradePrice)
        {
            if (dropper_3.speedLevel < 20)
            {
                variableControl.money -= dropper_3.orbSpeedUpgradePrice;
                dropper_3.upgradeDropSpeed();
                textControl.updateDropperThreeDropSpeedButton();
                textControl.updateMoney();
            }
            else
            {
                textControl.DropperThreeDropSpeedText.text = "Upgrades\nComplete";
            }
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    public void upgradeDropperThreeOrbValue()
    {
        if (variableControl.money >= dropper_3.orbValueUpgradePrice)
        {
            variableControl.money -= dropper_3.orbValueUpgradePrice;
            dropper_3.upgradeOrbValue();
            textControl.updateDropperThreeOrbValueButton();
            textControl.updateMoney();
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    //Upgrade Buttons Dropper 4
    public void upgradeDropperFourDropSpeed()
    {
        if (variableControl.money >= dropper_4.orbSpeedUpgradePrice)
        {
            if (dropper_4.speedLevel < 20)
            {
                variableControl.money -= dropper_4.orbSpeedUpgradePrice;
                dropper_4.upgradeDropSpeed();
                textControl.updateDropperFourDropSpeedButton();
                textControl.updateMoney();
            }
            else
            {
                textControl.DropperFourDropSpeedText.text = "Upgrades\nComplete";
            }
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    public void upgradeDropperFourOrbValue()
    {
        if (variableControl.money >= dropper_4.orbValueUpgradePrice)
        {
            variableControl.money -= dropper_4.orbValueUpgradePrice;
            dropper_4.upgradeOrbValue();
            textControl.updateDropperFourOrbValueButton();
            textControl.updateMoney();
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    //Upgrade Buttons Dropper 5
    public void upgradeDropperFiveDropSpeed()
    {
        if (variableControl.money >= dropper_5.orbSpeedUpgradePrice)
        {
            if (dropper_5.speedLevel < 20)
            {
                variableControl.money -= dropper_5.orbSpeedUpgradePrice;
                dropper_5.upgradeDropSpeed();
                textControl.updateDropperFiveDropSpeedButton();
                textControl.updateMoney();
            }
            else
            {
                textControl.DropperFiveDropSpeedText.text = "Upgrades\nComplete";
            }
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    public void upgradeDropperFiveOrbValue()
    {
        if (variableControl.money >= dropper_5.orbValueUpgradePrice)
        {
            variableControl.money -= dropper_5.orbValueUpgradePrice;
            dropper_5.upgradeOrbValue();
            textControl.updateDropperFiveOrbValueButton();
            textControl.updateMoney();
        }
        else
        {
            spriteControl.LowMoneySymbolActivation();
        }
    }
    //End of Upgrade Methods
}