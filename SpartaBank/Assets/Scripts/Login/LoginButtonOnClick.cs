using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginButtonOnClick : MonoBehaviour
{
    public GameObject panel;
    public InputField idInputField;
    public InputField psInputField;

    public void ButtonOnClick()
    {
        bool currectID = PlayerPrefs.HasKey(idInputField.text);
        bool currectPS = (PlayerPrefs.GetString(idInputField.text) == psInputField.text);

        if (currectID && currectPS)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            panel.SetActive(true);
        }
    }
}
