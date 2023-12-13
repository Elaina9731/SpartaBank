using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositInputField : MonoBehaviour
{
    public InputField depositInputField;
    public GameObject panel;
    public Text balanceMoneyText;
    public Text currentMoneyText;

    public void Start()
    {
        depositInputField.onSubmit.AddListener(delegate { InputDepositMoney(depositInputField); });
    }

    private void InputDepositMoney(InputField input)
    {
        if (input.text.Length > 0)
        {
            if (int.Parse(input.text) <= BankManager.instance.balanceMoney)
            {
                BankManager.instance.cash += int.Parse(input.text);
                BankManager.instance.balanceMoney -= int.Parse(input.text);
                balanceMoneyText.text = BankManager.instance.balanceMoney.ToString("#,##0");
                currentMoneyText.text = BankManager.instance.cash.ToString("#,##0");
            }
            else if (int.Parse(input.text) > BankManager.instance.balanceMoney)
            {
                panel.SetActive(true);
            }
        }
    }
}
