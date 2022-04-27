using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    public int currency = 100;
    public TextMeshProUGUI currencyText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currencyText.text = "Coins: " + currency;
    }

    public int GetCurrency ()
    {
        return currency;
    }

    public void SetCurrency (int curr)
    {
        currency = curr;
    }

    public int addCurrency (int moreCurrency)
    {
       return currency += moreCurrency;
    }

    public int subCurrency (int lessCurrency)
    {
       return currency -= lessCurrency;
    }
}
