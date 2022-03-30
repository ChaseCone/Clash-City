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
        currencyText.text = "Currency: " + currency; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateScore (int scoreToAdd)
    {

    }
}
