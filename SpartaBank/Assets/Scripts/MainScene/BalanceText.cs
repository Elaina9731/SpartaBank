using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalanceText : MonoBehaviour
{
    public Text balanceMoneyText;

    private void Start()
    {
        balanceMoneyText.text = BankManager.instance.balanceMoney.ToString("#,##0");
    }
}
