using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacementManager : MonoBehaviour
{
    public GameObject cannon1;
    public GameObject crossbow1;
    public GameObject farm1;
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

    // Start is called before the first frame update
    void Start()
    {
        exitShop.onClick.AddListener(ExitShop);
        buyFarm.onClick.AddListener(BuyFarm);
        buyCannon.onClick.AddListener(BuyCannon);
        buyCrossbow.onClick.AddListener(BuyCrossbow);
        buyMage.onClick.AddListener(BuyMage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PromptShop(GameObject clicked)
    {
        currScript = clicked.GetComponent<ClickDetector>();
        shopUI.SetActive(true);

        //refScript.currTower = ClickDetector.TowerType.cannon;
        //PlaceTower(clicked);
    }

    public void PromptInfo(GameObject clicked)
    {

    }

    public void PlaceTower(GameObject clicked, ClickDetector.TowerType towerType)
    {
        GameObject tower;
        if (towerType == ClickDetector.TowerType.cannon)
        {
            tower = Instantiate(cannon1, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.farm)
        {
            tower = Instantiate(farm1, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.crossbow)
        {
            tower = Instantiate(crossbow1, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(23, 180, 0, Space.World);
        }
        else if (towerType == ClickDetector.TowerType.mage)
        {
            tower = Instantiate(mage, clicked.transform.position, clicked.transform.rotation);
            tower.transform.Rotate(-67, 180, 0, Space.World);
        }
    }

    private void ExitShop()
    {
        shopUI.SetActive(false);
    }

    private void BuyFarm()
    {
        PlaceTower(currScript.gameObject, ClickDetector.TowerType.farm);
        shopUI.SetActive(false);
    }

    private void BuyCannon()
    {
        PlaceTower(currScript.gameObject, ClickDetector.TowerType.cannon);
        shopUI.SetActive(false);
    }

    private void BuyCrossbow()
    {
        PlaceTower(currScript.gameObject, ClickDetector.TowerType.crossbow);
        shopUI.SetActive(false);
    }

    private void BuyMage()
    {
        PlaceTower(currScript.gameObject, ClickDetector.TowerType.mage);
        shopUI.SetActive(false);
    }
}
