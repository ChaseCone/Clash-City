using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    // Start is called before the first frame update
    void Start()
    {
        exitShop.onClick.AddListener(ExitShop);
        buyFarm.onClick.AddListener(BuyFarm);
        buyCannon.onClick.AddListener(BuyCannon);
        buyCrossbow.onClick.AddListener(BuyCrossbow);
        buyMage.onClick.AddListener(BuyMage);

        exitInfo.onClick.AddListener(ExitInfo);
        remove.onClick.AddListener(Remove);
        upgrade.onClick.AddListener(Upgrade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PromptShop(GameObject clicked)
    {
        if (shopUI.activeSelf == true)
            currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        currScript = clicked.GetComponent<ClickDetector>();
        infoUI.SetActive(false);
        shopUI.SetActive(true);
        clicked.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    public void PromptInfo(GameObject clicked)
    {
        if (infoUI.activeSelf == true)
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
        if (currScript.currTower == ClickDetector.TowerType.farm1)
        {
            Destroy(currScript.placedTower);
            currScript.currTower = ClickDetector.TowerType.farm2;
            PlaceTower(currScript.gameObject, ClickDetector.TowerType.farm2);
        }
        else if (currScript.currTower == ClickDetector.TowerType.farm2)
        {
            Destroy(currScript.placedTower);
            currScript.currTower = ClickDetector.TowerType.farm3;
            PlaceTower(currScript.gameObject, ClickDetector.TowerType.farm3);
        }
        else if (currScript.currTower == ClickDetector.TowerType.cannon1)
        {
            Destroy(currScript.placedTower);
            currScript.currTower = ClickDetector.TowerType.cannon2;
            PlaceTower(currScript.gameObject, ClickDetector.TowerType.cannon2);
        }
        else if (currScript.currTower == ClickDetector.TowerType.cannon2)
        {
            Destroy(currScript.placedTower);
            currScript.currTower = ClickDetector.TowerType.cannon3;
            PlaceTower(currScript.gameObject, ClickDetector.TowerType.cannon3);
        }
        else if (currScript.currTower == ClickDetector.TowerType.crossbow1)
        {
            Destroy(currScript.placedTower);
            currScript.currTower = ClickDetector.TowerType.crossbow2;
            PlaceTower(currScript.gameObject, ClickDetector.TowerType.crossbow2);
        }
        else if (currScript.currTower == ClickDetector.TowerType.crossbow2)
        {
            Destroy(currScript.placedTower);
            currScript.currTower = ClickDetector.TowerType.crossbow3;
            PlaceTower(currScript.gameObject, ClickDetector.TowerType.crossbow3);
        }


        infoUI.SetActive(false);
        currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void BuyFarm()
    {
        PlaceTower(currScript.gameObject, ClickDetector.TowerType.farm1);
        shopUI.SetActive(false);
        currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void BuyCannon()
    {
        PlaceTower(currScript.gameObject, ClickDetector.TowerType.cannon1);
        shopUI.SetActive(false);
        currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void BuyCrossbow()
    {
        PlaceTower(currScript.gameObject, ClickDetector.TowerType.crossbow1);
        shopUI.SetActive(false);
        currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void BuyMage()
    {
        PlaceTower(currScript.gameObject, ClickDetector.TowerType.mage);
        shopUI.SetActive(false);
        currScript.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }
}
