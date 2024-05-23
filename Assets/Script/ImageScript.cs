using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject male;
    public GameObject female;
    public Sprite[] spriteArray;
    public GameObject imageHolder;
    public Slider SliderHeight;
    public Slider SliderWidth;


    public void showfemale(bool value)
    {
        female.SetActive(value);
    }

    public void showmale(bool value)
    {
        male.SetActive(value);
    }


    public void changeImage(int index)
    {
        if (index == 0)
            imageHolder.GetComponent<Image>().sprite = spriteArray[0];

        else if (index == 1)
            imageHolder.GetComponent<Image>().sprite = spriteArray[1];
    }


    public void changeHeight(float height)
    {
        Debug.Log("New Height " + height);
        float width = imageHolder.GetComponent<RectTransform>().sizeDelta.x;
        imageHolder.GetComponent<RectTransform>().sizeDelta = new Vector2(width, height);
    }
    public void changeWidth(float width)
    {
        Debug.Log("New Width " + width);
        float height = imageHolder.GetComponent<RectTransform>().sizeDelta.y;
        imageHolder.GetComponent<RectTransform>().sizeDelta = new Vector2(width, height);
    }
    }

