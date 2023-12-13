using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawalButtonOnClick : MonoBehaviour
{
    public GameObject panel;
    public Text balanceMoneyText;
    public Text currentMoneyText;

    public void Withdrawal10000()
    {
        if (BankManager.instance.cash >= 10000)
        {
            BankManager.instance.balanceMoney += 10000;
            BankManager.instance.cash -= 10000;
            balanceMoneyText.text = BankManager.instance.balanceMoney.ToString("#,##0");
            currentMoneyText.text = BankManager.instance.cash.ToString("#,##0");
        }
        else
        {
            panel.SetActive(true);
        }
    }

    public void Withdrawal30000()
    {
        if (BankManager.instance.cash >= 30000)
        {
            BankManager.instance.balanceMoney += 30000;
            BankManager.instance.cash -= 30000;
            balanceMoneyText.text = BankManager.instance.balanceMoney.ToString("#,##0");
            currentMoneyText.text = BankManager.instance.cash.ToString("#,##0");
        }
        else
        {
            panel.SetActive(true);
        }
    }

    public void Withdrawal50000()
    {
        if (BankManager.instance.cash >= 50000)
        {
            BankManager.instance.balanceMoney += 50000;
            BankManager.instance.cash -= 50000;
            balanceMoneyText.text = BankManager.instance.balanceMoney.ToString("#,##0");
            currentMoneyText.text = BankManager.instance.cash.ToString("#,##0");
        }
        else
        {
            panel.SetActive(true);
        }
    }
}
