using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodePanel : MonoBehaviour
{
    [SerializeField] Text codeText;
    //[SerializeField] TextMeshPro codeTextt;
    string codeTextValue = "";
    
    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "2890")
        {
            ele.isSafeOpened = true;
        }
        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void addNum(string digit)
    {
        codeTextValue += digit;
    }

}