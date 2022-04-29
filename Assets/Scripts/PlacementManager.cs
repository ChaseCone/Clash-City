using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlacementManager : MonoBehaviour
{
    public GameObject cannon1;
    public GameObject crossbow1;
    public GameObject farm1;
    public GameObject cannon2;
    public GameObject crossbow2;
    public GameObject farm2;
    public GameObject cannon3;
    public GameObject crossbow3;
    public GameObject farm3;
    public GameObject mage;
    public GameObject shopUI;
    public GameObject infoUI;
    ClickDetector currScript;

    public Button buyFarm;
    public Button buyCrossbow;
    public Button buyCannon;
    public Button buyMage;
    public Button exitShop;

    public Button upgrade;
    public Button remove;
    public Button exitInfo;

    GameObject currencyManager;
    CurrencyManager currMan;

    private int costToBuyFarm = 100;
    private int costToBuyCrossbow = 50;
    private int costToBuyCannon = 150;
    private int costToBuyMage = 500;

    private int costToBuyFarm2 = 300;
    private int costToBuyCrossbow2 = 200;
    private int costToBuyCannon2 = 400;

    private int costToBuyFarm3 = 500;
    private int costToBuyCrossbow3 = 400;
    private int costToBuyCannon3 = 1000;

    public TextMeshProUGUI buyFarmButton;
    public TextMeshProUGUI buyCrossbowButton;
    public TextMeshProUGUI buyCannonButton;
    public TextMeshProUGUI buyMageButton;
    public TextMeshProUGUI upgradeButton;

    // Start is called before the first frame update
    void Start()
    {
        currencyManager = GameObject.Find("CurrencyManager");
        currMan = currencyManager.GetComponent<CurrencyManager>();

        exitShop.onClick.AddListener(ExitShop);
        buyFarm.onClick.AddListener(BuyFarm);
        buyCannon.onClick.AddListener(BuyCannon);
        buyCrossbow.onClick.AddListener(BuyCrossbow);
        buyMage.onClick.AddListener(BuyMage);

        exitInfo.onClick.AddListener(ExitInfo);
        remove.onClick.AddListener(Remove);
        upgrade.onClick.AddListener(Upgrade);

        buyFarmButton.text = "FARM- $" + costToBuyFarm;
        buyCrossbowButton.text = "CROSSBOW- $" + costToBuyCrossbow;
        buyCannonButton.text = "CANNON- $" + costToBuyCannon;
        buyMageButton.text = "MAGE- $" + costToBuyMage;
    }

    // Update is called once per frame
    void Update()
    {
        if(infoUI.activeSelf == true && currScript.currTower == ClickDetector.TowerType.farm1)
        {
            upgradeButton.text = "UPGRADE- $" + costToBuyFarm2;
        }
        else if (infoUI.activeSelf == true && currScript.currTower == ClickDetector.TowerType.farm2)
        {
            upgradeButton.text = "UPGRADE- $" + costToBuyFarm3;
        }
        else if (infoUI.activeSelf == true && currScript.currTower == ClickDetector.TowerType.farm3)
        {
            upgradeButton.text = "MAX LEVEL";
        }
        else if (infoUI.activeSelf == true && currScript.currTower == ClickDetector.TowerType.crossbow1)
        {
            upgradeButton.text = "UPGRADE- $" + costToBuyCrossbow2;
        }
        else if (infoUI.activeSelf == true && currScript.currTower == ClickDetector.TowerType.crossbow2)
        {
            upgradeButton.text = "UPGRADE- $" + costToBuyCrossbow3;
        }
        else if (infoUI.activeSelf == true && currScript.currTower == ClickDetector.TowerType.crossbow3)
        {
            upgradeButton.text = "MAX LEVEL";
        }
        else if (infoUI.activeSelf == true && currScript.currTower == ClickDetector.TowerType.cannon1)
        {
            upgradeButton.text = "UPGRADE- $" + costToBuyCannon2;
        }
        else if (infoUI.activeSelf == true && currScript.currTower == ClickDetector.TowerType.cannon2)
        {
            upgradeButton.text = "UPGRADE- $" + costToBuyCannon3;
        }
        else if (infoUI.activeSelf == true && currScript.currTower == ClickDetector.TowerType.cannon3)
        {
            upgradeButton.text = "MAX LEVEL";
        }
        else
        {
            upgradeButton.text = "MAX LEVEL";
        }
    }

    public void PromptShop(GameObject clicked)
    {
        if (shopUI.activeSelf == true || infoUI.activeSelf == true)
            currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        currScript = clicked.GetComponent<ClickDetector>();
        infoUI.SetActive(false);
        shopUI.SetActive(true);
        clicked.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    public void PromptInfo(GameObject clicked)
    {
        if (shopUI.activeSelf == true || infoUI.activeSelf == true)
            currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        currScript = clicked.GetComponent<ClickDetector>();
        infoUI.SetActive(true);
        shopUI.SetActive(false);
        clicked.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    public void PlaceTower(GameObject clicked, ClickDetector.TowerType towerType)
    {
        GameObject tower;
        currScript.currTower = towerType;
        if (towerType == ClickDetector.TowerType.cannon1)
        {
            tower = Instantiate(cannon1, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.farm1)
        {
            tower = Instantiate(farm1, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.crossbow1)
        {
            tower = Instantiate(crossbow1, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.cannon2)
        {
            tower = Instantiate(cannon2, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.farm2)
        {
            tower = Instantiate(farm2, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.crossbow2)
        {
            tower = Instantiate(crossbow2, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.cannon3)
        {
            tower = Instantiate(cannon3, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.farm3)
        {
            tower = Instantiate(farm3, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.crossbow3)
        {
            tower = Instantiate(crossbow3, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else
        {
            tower = Instantiate(mage, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(-67, 180, 0, Space.World);
        }
        currScript.placedTower = tower;
    }

    private void ExitShop()
    {
        shopUI.SetActive(false);
        currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void ExitInfo()
    {
        infoUI.SetActive(false);
        currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void Remove()
    {
        currScript.currTower = ClickDetector.TowerType.none;
        Destroy(currScript.placedTower);
        infoUI.SetActive(false);
        currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void Upgrade()
    {
        bool ableTo = false;
        if (currScript.currTower == ClickDetector.TowerType.farm1)
        {
            if (currMan.GetCurrency() >= costToBuyFarm2)
            {
                currMan.subCurrency(costToBuyFarm2);
                ableTo = true;
                Destroy(currScript.placedTower);
                currScript.currTower = ClickDetector.TowerType.farm2;
                PlaceTower(currScript.gameObject, ClickDetector.TowerType.farm2);
            }
            else
                StartCoroutine(CantAfford());
        }
        else if (currScript.currTower == ClickDetector.TowerType.farm2)
        {
            if (currMan.GetCurrency() >= costToBuyFarm3)
            {
                currMan.subCurrency(costToBuyFarm3);
                ableTo = true;
                Destroy(currScript.placedTower);
                currScript.currTower = ClickDetector.TowerType.farm3;
                PlaceTower(currScript.gameObject, ClickDetector.TowerType.farm3);
            }
            else
                StartCoroutine(CantAfford());
        }
        else if (currScript.currTower == ClickDetector.TowerType.cannon1)
        {
            if (currMan.GetCurrency() >= costToBuyCannon2)
            {
                currMan.subCurrency(costToBuyCannon2);
                ableTo = true;
                Destroy(currScript.placedTower);
                currScript.currTower = ClickDetector.TowerType.cannon2;
                PlaceTower(currScript.gameObject, ClickDetector.TowerType.cannon2);
            }
            else
                StartCoroutine(CantAfford());
        }
        else if (currScript.currTower == ClickDetector.TowerType.cannon2)
        {
            if (currMan.GetCurrency() >= costToBuyCannon3)
            {
                currMan.subCurrency(costToBuyCannon3);
                ableTo = true;
                Destroy(currScript.placedTower);
                currScript.currTower = ClickDetector.TowerType.cannon3;
                PlaceTower(currScript.gameObject, ClickDetector.TowerType.cannon3);
            }
            else
                StartCoroutine(CantAfford());
        }
        else if (currScript.currTower == ClickDetector.TowerType.crossbow1)
        {
            if (currMan.GetCurrency() >= costToBuyCrossbow2)
            {
                currMan.subCurrency(costToBuyCrossbow2);
                ableTo = true;
                Destroy(currScript.placedTower);
                currScript.currTower = ClickDetector.TowerType.crossbow2;
                PlaceTower(currScript.gameObject, ClickDetector.TowerType.crossbow2);
            }
            else
                StartCoroutine(CantAfford());
        }
        else if (currScript.currTower == ClickDetector.TowerType.crossbow2)
        {
            if (currMan.GetCurrency() >= costToBuyCrossbow3)
            {
                currMan.subCurrency(costToBuyCrossbow3);
                ableTo = true;
                Destroy(currScript.placedTower);
                currScript.currTower = ClickDetector.TowerType.crossbow3;
                PlaceTower(currScript.gameObject, ClickDetector.TowerType.crossbow3);
            }
            else
                StartCoroutine(CantAfford());
        }

        if (ableTo == true)
        {
            infoUI.SetActive(false);
            currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
    }

    IEnumerator CantAfford()
    {
        upgradeButton.color = Color.red;
        buyFarmButton.color = Color.red;
        buyCannonButton.color = Color.red;
        buyCrossbowButton.color = Color.red;
        buyMageButton.color = Color.red;
        yield return new WaitForSeconds(1);
        upgradeButton.color = Color.white;
        buyFarmButton.color = Color.white;
        buyCannonButton.color = Color.white;
        buyCrossbowButton.color = Color.white;
        buyMageButton.color = Color.white;
        yield return null;
    }

    private void BuyFarm()
    {
        if (currMan.GetCurrency() >= costToBuyFarm)
        {
            currMan.subCurrency(costToBuyFarm);
            PlaceTower(currScript.gameObject, ClickDetector.TowerType.farm1);
            shopUI.SetActive(false);
            currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else
            StartCoroutine(CantAfford());
    }

    private void BuyCannon()
    {
        if (currMan.GetCurrency() >= costToBuyCannon)
        {
            currMan.subCurrency(costToBuyCannon);
            PlaceTower(currScript.gameObject, ClickDetector.TowerType.cannon1);
            shopUI.SetActive(false);
            currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else
            StartCoroutine(CantAfford());
    }

    private void BuyCrossbow()
    {
        if (currMan.GetCurrency() >= costToBuyCrossbow)
        {
            currMan.subCurrency(costToBuyCrossbow);
            PlaceTower(currScript.gameObject, ClickDetector.TowerType.crossbow1);
            shopUI.SetActive(false);
            currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else
            StartCoroutine(CantAfford());
    }

    private void BuyMage()
    {
        if (currMan.GetCurrency() >= costToBuyMage)
        {
            currMan.subCurrency(costToBuyMage);
            PlaceTower(currScript.gameObject, ClickDetector.TowerType.mage);
            shopUI.SetActive(false);
            currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else
            StartCoroutine(CantAfford());
    }
}