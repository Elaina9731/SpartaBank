using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DepositButton : MonoBehaviour
{
    public void DepositButtonOnClick()
    {
        SceneManager.LoadScene("DepositScene");
    }
}