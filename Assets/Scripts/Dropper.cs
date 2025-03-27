using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //Variables that change and their starting values as SerializedFields
    [SerializeField] public int unlockCost;

    [SerializeField] int orbInitialValue;

    [SerializeField] int orbInitialSpeed;

    [SerializeField] int orbValueInitialUpgradePrice;
    public int orbValueUpgradePrice;

    [SerializeField] int orbSpeedInitialUpgradePrice;
    public int orbSpeedUpgradePrice;

    [SerializeField] public float dropperCooldownTime;

    public int speedLevel = 1;
    public int valueLevel = 1;

    /*Static values
    [SerializeField] int colorSchemeOnePrice;
    [SerializeField] int colorSchemeTwoPrice;
    [SerializeField] int dropperSoundOnePrice;
    [SerializeField] int dropperSoundTwoPrice;*/

    public GameObject orb;
    public Orbs orbScript;

    public GameObject dropperTip;
    bool isDropperOnCooldown = false;

    Vector3 orbDropPosition;

    private void Awake()
    {
        orbScript = orb.GetComponent<Orbs>();
        //Initialize changing values to serialized starting values
        orbScript.collectionValue = orbInitialValue;
        orbScript.fallSpeed = orbInitialSpeed;
        orbValueUpgradePrice = orbValueInitialUpgradePrice;
        orbSpeedUpgradePrice = orbSpeedInitialUpgradePrice;
    }
    public void dropOrbForDropper0()
    {
        if(!isDropperOnCooldown)
        {
            Instantiate(orb, new Vector3(dropperTip.transform.position.x, dropperTip.transform.position.y, dropperTip.transform.position.z), Quaternion.identity);
            isDropperOnCooldown = true;
            StartCoroutine("dropperCooldownTimer");
        }
    }
    public void dropOrbForOtherDroppers()
    {
        Instantiate(orb, new Vector3(dropperTip.transform.position.x, dropperTip.transform.position.y, dropperTip.transform.position.z), Quaternion.identity);
    }
    public IEnumerator dropperCooldownTimer()
    {
        yield return new WaitForSeconds(dropperCooldownTime);
        isDropperOnCooldown = false;
    }
    public void upgradeDropSpeed()
    {
        if(speedLevel < 20)
        {
            orbScript.fallSpeed += 0.5f;
            orbSpeedUpgradePrice++;
            dropperCooldownTime *= .9f;
            speedLevel++;
        }
    }
    public void upgradeOrbValue()
    {
        orbScript.collectionValue++;
        orbValueUpgradePrice++;
        valueLevel++;
    }
}
