using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    private int currency;
    public TextMeshProUGUI currencyText;
    // Start is called before the first frame update
    void Start()
    {
        currency = 0;
        currencyText.text = "Coins: " + currency; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetCurrency ()
    {
        return currency;
    }

    public void SetCurrency (int curr)
    {
        currency = curr;
    }

    private int addCurrency (int moreCurrency)
    {
       return currency += moreCurrency;
    }

    private int subCurrency (int lessCurrency)
    {
       return currency -= lessCurrency;
    }
}
