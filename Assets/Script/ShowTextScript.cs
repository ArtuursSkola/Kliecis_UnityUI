using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScrip : MonoBehaviour
{
    string text;
    int num;
    public GameObject inputField;
    public GameObject inputField2;
    public GameObject displayField;
    string[] words = { "Ahoy ", "Greetings ", "Lord " };
    int randomNumb;


    public void getText()
    {
        randomNumb = Random.Range(0, words.Length);
        text = inputField.GetComponent<InputField>().text;
        if (inputField2 != null && !string.IsNullOrEmpty(inputField2.GetComponent<InputField>().text))
        {
            if (int.TryParse(inputField2.GetComponent<InputField>().text, out num))
            {
                int currentYear = System.DateTime.Now.Year;
                displayField.GetComponent<Text>().text =
                                        words[randomNumb] + text.ToLower() + " You're " + (currentYear - num) + " years old";
            }
            else
            {
                displayField.GetComponent<Text>().text = "Please enter a valid number in the second input field";
            }
        }
        else
        {
            displayField.GetComponent<Text>().text = "Please fill in both input fields";
        }
    }
        
    }

