using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawalInputField : MonoBehaviour
{
    public InputField withdrawalInputField;
    public GameObject panel;
    public Text balanceMoneyText;
    public Text currentMoneyText;

    public void Start()
    {
        withdrawalInputField.onSubmit.AddListener(delegate { InputWithdrawalMoney(withdrawalInputField); });
    }

    private void InputWithdrawalMoney(InputField input)
    {
        if (input.text.Length > 0)
        {
            if (int.Parse(input.text) <= BankManager.instance.cash)
            {
                BankManager.instance.balanceMoney += int.Parse(input.text);
                BankManager.instance.cash -= int.Parse(input.text);
                balanceMoneyText.text = BankManager.instance.balanceMoney.ToString("#,##0");
                currentMoneyText.text = BankManager.instance.cash.ToString("#,##0");
            }
            else if (int.Parse(input.text) > BankManager.instance.cash)
            {
                panel.SetActive(true);
            }
        }
    }
}
