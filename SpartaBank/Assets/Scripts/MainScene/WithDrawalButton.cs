using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WithDrawalButton : MonoBehaviour
{
    public void WithDrawalButtonOnClick()
    {
        SceneManager.LoadScene("WithdrawalScene");
    }
}
