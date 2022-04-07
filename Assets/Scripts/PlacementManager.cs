using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacementManager : MonoBehaviour
{
    public GameObject cube;
    public GameObject shop;
    public GameObject info;
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
        shop.SetActive(true);
        //refScript.currTower = ClickDetector.TowerType.cannon;
        //PlaceTower(clicked);
    }

    public void PromptInfo(GameObject clicked)
    {
        ClickDetector refScript = clicked.GetComponent<ClickDetector>();
        info.SetActive(true);
    }

    public void PlaceTower(GameObject clicked)
    {
        GameObject tower = Instantiate(cube, clicked.transform.position, clicked.transform.rotation);
    }
}
