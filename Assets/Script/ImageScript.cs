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
    public GameObject sizeSlider;
    public GameObject rotationSlider;



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

        //else if (index == 2)
            //imageHolder.GetComponent<Image>().sprite = spriteArray[2];
    }


    public void changeSize()
    {
        float size = sizeSlider.GetComponent<Slider>().value;
        imageHolder.transform.localScale = new Vector2(1F * size, 1F * size);
    }

    public void changeRotation()
    {
        float rotation = rotationSlider.GetComponent<Slider>().value;
        imageHolder.transform.localRotation = Quaternion.Euler(0, 0, rotation * 360);
    }
}
