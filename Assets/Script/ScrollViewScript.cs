using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewScript : MonoBehaviour
{
    public DropDown DropD;
    public Text[] textPrefabs;
    public Transform scrollViewContent;
    
    void Start()
    {
        DropD.onValueChanged.addListener(DropDValueChanged);
    }
    private void DropDValueChanged(int index)
    {
        foreach (Transform child in scrollViewContent)
        {
            Destroy(child.gameObject);
        }
        Instance(textPrefabs[index], scrollViewContent);
    }

}