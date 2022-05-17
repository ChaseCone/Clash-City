using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameEnder : MonoBehaviour
{
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnDestroy()
    {
        gameManager.GetComponent<GameManager>().GameOver();
    }
}
