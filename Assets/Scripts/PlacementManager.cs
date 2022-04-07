using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacementManager : MonoBehaviour
{
    public GameObject cube;
    public GameObject shopUI;
    public GameObject infoUI;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PromptShop(GameObject clicked)
    {
        ClickDetector refScript = clicked.GetComponent<ClickDetector>();
        shopUI.SetActive(true);
        //refScript.currTower = ClickDetector.TowerType.cannon;
        //PlaceTower(clicked);
    }

    public void PromptInfo(GameObject clicked)
    {

    }

    public void PlaceTower(GameObject clicked)
    {
        GameObject tower = Instantiate(cube, clicked.transform.position, clicked.transform.rotation);
    }
}
