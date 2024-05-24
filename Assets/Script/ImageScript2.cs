using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageScript2 : MonoBehaviour
{
    public GameObject hat1;
    public GameObject hat2;
    public GameObject hat3;
    public GameObject boots1;
    public GameObject boots2;
    public GameObject bootss2;
    public GameObject boots3;
    public GameObject shirt1;
    public GameObject shirt2;
    public GameObject shirt3;
    public GameObject amulet1;
    public GameObject amulet2;
    public GameObject amulet3;
    public GameObject pants1;
    public GameObject pants2;
    public GameObject pants3;
    public GameObject shield1;
    public GameObject shield2;
    public GameObject shield3;

    public GameObject CharHolder;
    public Sprite[] SpriteArray;

    public void showBoots(Boolean value)
    {
        boots1.SetActive(value);
        boots2.SetActive(value);
        bootss2.SetActive(value);
        boots3.SetActive(value);
    }
    public void showHat(Boolean value)
    {
        hat1.SetActive(value);
        hat2.SetActive(value);
        hat3.SetActive(value);
    }
    public void showShirt(Boolean value)
    {
        shirt1.SetActive(value);
        shirt2.SetActive(value);
        shirt3.SetActive(value);
    }
    public void showShield(Boolean value)
    {
        shield1.SetActive(value);
        shield2.SetActive(value);
        shield3.SetActive(value);
    }
    public void showAmulet(Boolean value)
    {
        amulet1.SetActive(value);
        amulet2.SetActive(value);
        amulet3.SetActive(value);
    }
    public void showPants(Boolean value)
    {
        pants1.SetActive(value);
        pants2.SetActive(value);
        pants3.SetActive(value);
    }
    public void changeImage(int index)
    {
        CharHolder.GetComponent<Image>().sprite = SpriteArray[index];
    }    
}
