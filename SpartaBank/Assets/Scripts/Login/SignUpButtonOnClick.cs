using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignUpButtonOnClick : MonoBehaviour
{
    public GameObject SignUpPage;
    public GameObject ID;
    public GameObject PS;
    public GameObject LoginButton;
    public GameObject SignUpButton;

    public void ButtonOnClick()
    {
        ID.SetActive(false);
        PS.SetActive(false);
        LoginButton.SetActive(false);
        SignUpButton.SetActive(false);
        SignUpPage.SetActive(true);
    }
}
