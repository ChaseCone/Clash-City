using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    private GameObject placementManager;
    private PlacementManager placementManagerScript;

    public enum TowerType
    {
        none,
        farm1,
        farm2,
        farm3,
        crossbow1,
        crossbow2,
        crossbow3,
        cannon1,
        cannon2,
        cannon3,
        mage
    }
    public TowerType currTower = TowerType.none;
    public GameObject placedTower;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
        placementManager = GameObject.Find("PlacementManager");
        placementManagerScript = placementManager.GetComponent<PlacementManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(currTower == TowerType.none)
        {
            placementManagerScript.PromptShop(gameObject);
        }
        else
        {
            placementManagerScript.PromptInfo(gameObject);
        }
    }

}
