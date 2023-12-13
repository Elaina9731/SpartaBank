using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DepositBackButton : MonoBehaviour
{
    public void DepositBackButtonOnClick()
    {
        SceneManager.LoadScene("MainScene");
    }
}
