using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager : MonoBehaviour
{
    public int farmLevel;
    GameObject currencyManager;
    CurrencyManager currMan;
    // Start is called before the first frame update
    void Start()
    {
        currencyManager = GameObject.Find("CurrencyManager");
        currMan = currencyManager.GetComponent < CurrencyManager >();

        if (farmLevel == 1)
            InvokeRepeating("CollectMoney1", 7.0f, 7.0f);
        else if (farmLevel == 2)
            InvokeRepeating("CollectMoney2", 4.0f, 4.0f);
        else if (farmLevel == 3)
            InvokeRepeating("CollectMoney3", 3.0f, 3.0f);


    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void CollectMoney1()
    {
        currMan.addCurrency(10);
    }

    public void CollectMoney2()
    {
        currMan.addCurrency(15);
    }

    public void CollectMoney3()
    {
        currMan.addCurrency(20);
    }


}
