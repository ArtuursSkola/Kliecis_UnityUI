using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSound : MonoBehaviour
{
    public Dropdown DropD;
    public AudioClip maleSound;
    public AudioClip femaleSound;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        DropD.onValueChanged.AddListener(delegate { PlaySound(DropD); });
    }

    void PlaySound(Dropdown change)
    {
        switch(change.value)
        {
            case 0:
                audioSource.clip = maleSound;
                break;
            case 1:
                audioSource.clip = femaleSound;
                break;
            default:
                return;
        }
        audioSource.Play();
    }
}
