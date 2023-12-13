using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashText : MonoBehaviour
{
    public Text currentCashText;

    private void Start()
    {
        currentCashText.text = BankManager.instance.cash.ToString("#,##0");
    }
}
