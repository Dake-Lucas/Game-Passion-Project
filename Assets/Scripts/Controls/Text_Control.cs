using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Text_Control : MonoBehaviour
{
    //Controls
    Variable_Control variableControl;

    //Droppers
    public GameObject dropper_0_body;
    public GameObject dropper_1_body;
    public GameObject dropper_2_body;
    public GameObject dropper_3_body;
    public GameObject dropper_4_body;
    public GameObject dropper_5_body;

    Dropper dropper_0;
    Dropper dropper_1;
    Dropper dropper_2;
    Dropper dropper_3;
    Dropper dropper_4;
    Dropper dropper_5;

    //Public Spaces for Dragging
    public TMP_Text moneyText;
    public TMP_Text DropperZeroDropSpeedText;
    public TMP_Text DropperOneDropSpeedText;
    public TMP_Text DropperTwoDropSpeedText;
    public TMP_Text DropperThreeDropSpeedText;
    public TMP_Text DropperFourDropSpeedText;
    public TMP_Text DropperFiveDropSpeedText;

    public TMP_Text DropperZeroOrbValueText;
    public TMP_Text DropperOneOrbValueText;
    public TMP_Text DropperTwoOrbValueText;
    public TMP_Text DropperThreeOrbValueText;
    public TMP_Text DropperFourOrbValueText;
    public TMP_Text DropperFiveOrbValueText;

    public TMP_Text unlockDropperOneText;
    public TMP_Text unlockDropperTwoText;
    public TMP_Text unlockDropperThreeText;
    public TMP_Text unlockDropperFourText;
    public TMP_Text unlockDropperFiveText;

    //Other variables
    private void Start()
    {
        //Assign Controls
        variableControl = GetComponent<Variable_Control>();

        dropper_0 = dropper_0_body.GetComponent<Dropper>();
        dropper_1 = dropper_1_body.GetComponent<Dropper>();
        dropper_2 = dropper_2_body.GetComponent<Dropper>();
        dropper_3 = dropper_3_body.GetComponent<Dropper>();
        dropper_4 = dropper_4_body.GetComponent<Dropper>();
        dropper_5 = dropper_5_body.GetComponent<Dropper>();

        //Assign Variables

        //Assign text boxes to their initial values
        moneyText.text = "Money:   " + (int)variableControl.money;
        DropperZeroDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_0.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_0.speedLevel ;
        DropperOneDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_1.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_1.speedLevel;
        DropperTwoDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_2.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_2.speedLevel;
        DropperThreeDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_3.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_3.speedLevel;
        DropperFourDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_4.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_4.speedLevel;
        DropperFiveDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_5.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_5.speedLevel;

        DropperZeroOrbValueText.text = "Orb Value+\r\nCost: " + dropper_0.orbValueUpgradePrice + "\r\nLevel: " + dropper_0.valueLevel+ "\r\n";
        DropperOneOrbValueText.text = "Orb Value+\r\nCost: " + dropper_1.orbValueUpgradePrice + "\r\nLevel: " + dropper_1.valueLevel + "\r\n";
        DropperTwoOrbValueText.text = "Orb Value+\r\nCost: " + dropper_2.orbValueUpgradePrice + "\r\nLevel: " + dropper_2.valueLevel + "\r\n";
        DropperThreeOrbValueText.text = "Orb Value+\r\nCost: " + dropper_3.orbValueUpgradePrice + "\r\nLevel: " + dropper_3.valueLevel + "\r\n";
        DropperFourOrbValueText.text = "Orb Value+\r\nCost: " + dropper_4.orbValueUpgradePrice + "\r\nLevel: " + dropper_4.valueLevel + "\r\n";
        DropperFiveOrbValueText.text = "Orb Value+\r\nCost: " + dropper_5.orbValueUpgradePrice + "\r\nLevel: " + dropper_5.valueLevel + "\r\n";

        unlockDropperOneText.text = "Unlock:\r\n$" + dropper_1.unlockCost;
        unlockDropperTwoText.text = "Unlock:\r\n$" + dropper_2.unlockCost;
        unlockDropperThreeText.text = "Unlock:\r\n$" + dropper_3.unlockCost;
        unlockDropperFourText.text = "Unlock:\r\n$" + dropper_4.unlockCost;
        unlockDropperFiveText.text = "Unlock:\r\n$" + dropper_5.unlockCost;
    }
    public void updateMoney()
    {
        moneyText.text = "Money:  " + (int)variableControl.money;
    }

    //Upgrade Buttons for the droppers, text updates for drop speed
    public void updateDropperZeroDropSpeedButton()
    {
        DropperZeroDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_0.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_0.speedLevel;
    }
    public void updateDropperOneDropSpeedButton()
    {
        DropperOneDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_1.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_1.speedLevel;
    }
    public void updateDropperTwoDropSpeedButton()
    {
        DropperTwoDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_2.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_2.speedLevel;
    }
    public void updateDropperThreeDropSpeedButton()
    {
        DropperThreeDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_3.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_3.speedLevel;
    }
    public void updateDropperFourDropSpeedButton()
    {
        DropperFourDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_4.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_4.speedLevel;
    }
    public void updateDropperFiveDropSpeedButton()
    {
        DropperFiveDropSpeedText.text = "Drop Speed+\r\nCost: " + dropper_5.orbSpeedUpgradePrice + "\r\nLevel: " + dropper_5.speedLevel;
    }

    //For orb value updates
    public void updateDropperZeroOrbValueButton()
    {
        DropperZeroOrbValueText.text = "Orb Value+\r\nCost: " + dropper_0.orbValueUpgradePrice + "\r\nLevel: " + dropper_0.valueLevel + "\r\n";
    }
    public void updateDropperOneOrbValueButton()
    {
        DropperOneOrbValueText.text = "Orb Value+\r\nCost: " + dropper_1.orbValueUpgradePrice + "\r\nLevel: " + dropper_1.valueLevel + "\r\n";
    }
    public void updateDropperTwoOrbValueButton()
    {
        DropperTwoOrbValueText.text = "Orb Value+\r\nCost: " + dropper_2.orbValueUpgradePrice + "\r\nLevel: " + dropper_2.valueLevel + "\r\n";
    }
    public void updateDropperThreeOrbValueButton()
    {
        DropperThreeOrbValueText.text = "Orb Value+\r\nCost: " + dropper_3.orbValueUpgradePrice + "\r\nLevel: " + dropper_3.valueLevel + "\r\n";
    }
    public void updateDropperFourOrbValueButton()
    {
        DropperFourOrbValueText.text = "Orb Value+\r\nCost: " + dropper_4.orbValueUpgradePrice + "\r\nLevel: " + dropper_4.valueLevel + "\r\n";
    }
    public void updateDropperFiveOrbValueButton()
    {
        DropperFiveOrbValueText.text = "Orb Value+\r\nCost: " + dropper_5.orbValueUpgradePrice + "\r\nLevel: " + dropper_5.valueLevel + "\r\n";
    }
}
