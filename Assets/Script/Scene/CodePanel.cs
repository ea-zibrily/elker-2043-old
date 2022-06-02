using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{
    [SerializeField] Text codeText;
    string codeTextValue = "";
    
    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "2431")
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