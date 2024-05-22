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
    public GameObject boots3;

    public GameObject CharHolder;
    public Sprite[] SpriteArray;

    public void showBoots(Boolean value)
    {
        boots1.SetActive(value);
        boots2.SetActive(value);
        boots3.SetActive(value);
    }
    public void showHat(Boolean value)
    {
        hat1.SetActive(value);
        hat2.SetActive(value);
        hat3.SetActive(value);
    }
    public void changeImage(int index)
    {
        CharHolder.GetComponent<Image>().sprite = SpriteArray[index];
    }    
}
