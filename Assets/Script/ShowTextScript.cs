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
        num = int.Parse(inputField2.GetComponent<InputField>().text);
        int currentYear = System.DateTime.Now.Year;
        displayField.GetComponent<Text>().text =
                                words[randomNumb] + text.ToLower() + " You're "+(currentYear - num) + " years old";
    }
}
