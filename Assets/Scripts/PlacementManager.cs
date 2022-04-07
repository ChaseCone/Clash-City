using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacementManager : MonoBehaviour
{
    public GameObject cube;
    public Canvas shopUI;
    public Canvas infoUI;
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
        refScript.currTower = ClickDetector.TowerType.cannon;
        PlaceTower(clicked);
    }

    public void PromptInfo(GameObject clicked)
    {

    }

    public void PlaceTower(GameObject clicked)
    {
        GameObject tower = Instantiate(cube, clicked.transform.position, clicked.transform.rotation);
    }
}
