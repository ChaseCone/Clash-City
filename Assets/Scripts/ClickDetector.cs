using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    private GameObject placementManager;
    private PlacementManager placementManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        placementManager = GameObject.Find("PlacementManager");
        placementManagerScript = placementManager.GetComponent<PlacementManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("mouseDown");
        if(gameObject.tag == "Empty")
        {
            gameObject.tag = "Full";
            placementManagerScript.PlaceTower(gameObject);
        }
    }

}
