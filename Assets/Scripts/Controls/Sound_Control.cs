using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Control : MonoBehaviour
{
    public AudioSource backgroundSound;
    public AudioSource buttonUpgradeSound;
    private void Start()
    {
        backgroundSound.loop = true;
        backgroundSound.Play();
    }
    public void playButtonUpgradeSound()
    {
        buttonUpgradeSound.Play();
    }
}
