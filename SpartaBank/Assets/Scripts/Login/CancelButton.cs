using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour
{
    public GameObject SignUpPage;
    public GameObject ID;
    public GameObject PS;
    public GameObject LoginButton;
    public GameObject SignUpButton;

    public void ButtonOnClick()
    {
        SignUpPage.SetActive(false);
        ID.SetActive(true);
        PS.SetActive(true);
        LoginButton.SetActive(true);
        SignUpButton.SetActive(true);
    }
}
