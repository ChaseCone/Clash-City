using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementManager : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceTower(GameObject clicked)
    {
        GameObject tower = Instantiate(cube, clicked.transform.position, clicked.transform.rotation);
    }
}
