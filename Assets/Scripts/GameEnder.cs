using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameEnder : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject endCanvas;
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void RestartGame()
    {
        Debug.Log("restarting");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnDestroy()
    {
        mainCanvas.SetActive(false);
        endCanvas.SetActive(true);
    }
}
