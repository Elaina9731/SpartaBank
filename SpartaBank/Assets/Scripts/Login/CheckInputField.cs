using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CheckInputField : MonoBehaviour
{
    private InputBool inputBool;
    public Text errorText;
    public InputField inputField;

    private void Awake()
    {
        inputBool = transform.GetComponentInParent<InputBool>();
    }

    public void CheckID()
    {
        inputField.onValueChanged.AddListener((word) => inputField.text = Regex.Replace(word, @"[^a-zA-Z0-9]", ""));
        bool overlap = PlayerPrefs.HasKey(inputField.text);
        if (inputField.text.Length < 3 || inputField.text.Length > 10)
        {
            errorText.text = new string("ID를 확인해주세요.");
            inputBool.standardID = false;
        }
        else if (overlap)
        {
            errorText.text = new string("이미 존재하는 ID입니다.");
            inputBool.standardID = false;
        }
        else
        {
            errorText.text = "";
            inputBool.standardID = true;
        }
            
    }

    public void CheckName()
    {
        if (inputField.text.Length < 2 || inputField.text.Length > 5)
        {
            errorText.text = new string("Name를 확인해주세요.");
            inputBool.standardName = false;
        }
        else
        {
            errorText.text = "";
            inputBool.standardName = true;
        }
    }

    public void CheckPS()
    {
        inputField.onValueChanged.AddListener((word) => inputField.text = Regex.Replace(word, @"[^a-zA-Z0-9]", ""));
        if (inputField.text.Length < 5 || inputField.text.Length > 15)
        {
            errorText.text = new string("PS를 확인해주세요.");
            inputBool.standardPS = false;
        }
        else
        {
            errorText.text = "";
            inputBool.standardPS = true;
        }
            
    }

    public void CheckPSConfirm()
    {
        InputField ps = GameObject.Find("PSInputField").GetComponent<InputField>();
        inputField.onValueChanged.AddListener((word) => inputField.text = Regex.Replace(word, @"[^a-zA-Z0-9]", ""));
        if (ps.text != inputField.text)
        {
            errorText.text = new string("비밀번호가 서로 다릅니다.");
            inputBool.standardPSConfirm = false;
        }
        else
        {
            errorText.text = "";
            inputBool.standardPSConfirm = true;
        }
    }
}
