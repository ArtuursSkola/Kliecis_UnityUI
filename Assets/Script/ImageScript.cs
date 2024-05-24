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
    public GameObject SliderHeight;
    public GameObject SliderWidth;


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
    public void ChangeSize()
    {
        float sizeH = SliderHeight.GetComponent<Slider>().value;
        float sizeW = SliderWidth.GetComponent<Slider>().value;
        imageHolder.transform.localScale = new Vector3(1.0f * sizeH, 1.0f * sizeW, 1);
    }
    }

