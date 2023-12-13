using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CreateNewAccount : MonoBehaviour
{
    public GameObject SuccesPanel;
    public GameObject Panel;
    public InputField ID;
    public InputField PS;

    [SerializeField] private InputBool inputBool;

    private void Awake()
    {
        inputBool = transform.GetComponentInParent<InputBool>();
    }

    public void CreateAccount()
    {
        if (inputBool.standardID && inputBool.standardName && inputBool.standardPS && inputBool.standardPSConfirm)
        {
            PlayerPrefs.SetString(ID.text, PS.text);
            PlayerPrefs.Save();
            SuccesPanel.SetActive(true);
        }
        else
        {
            Panel.SetActive(true);
        }

    }
}
