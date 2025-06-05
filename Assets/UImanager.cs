using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    void Start()
    {
        
    }

   
    public void UpdateMoneyTxt(string moneyAmount)
    {
        txtMoney.text = moneyAmount;
    }
}
