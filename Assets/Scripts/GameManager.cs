using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject redSlime;
    public GameObject blueSlime;
    public GameObject wizard;
    public GameObject spider;
    public GameObject golem;

    public GameObject spawnLocation1;
    public GameObject spawnLocation2;
    public GameObject spawnLocation3;
    public GameObject spawnLocation4;
    public GameObject spawnLocation5;
    public GameObject spawnLocation6;
    private int wave = 0;
    public bool gameStarted= false;
    public TextMeshProUGUI waveText;
    public GameObject startCanvas;
    public GameObject mainCanvas;
    public Button startButton;

    public GameObject endCanvas;
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        restartButton.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted == true)
        {
            waveText.text = "Wave: " + wave;
            int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
            if (enemyCount == 0)
            {
                SpawnRound();
            }
        }
    }

    public void GameOver()
    {
        mainCanvas.SetActive(false);
        endCanvas.SetActive(true);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void SpawnRound()
    {
        int enemiesToSpawn = wave * 3 + 1;
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            GameObject spawnSpot;
            int spawnNumber = Random.Range(1, 7);
            if(spawnNumber == 1)
                spawnSpot = spawnLocation1;
            else if (spawnNumber == 2)
                spawnSpot = spawnLocation2;
            else if (spawnNumber == 3)
                spawnSpot = spawnLocation3;
            else if (spawnNumber == 4)
                spawnSpot = spawnLocation4;
            else if (spawnNumber == 5)
                spawnSpot = spawnLocation5;
            else 
                spawnSpot = spawnLocation6;

            GameObject enemySpawn;
            int spawnChance = Random.Range(1, 101);
            if (spawnChance < 30)
                enemySpawn = redSlime;
            else if (spawnChance < 60)
                enemySpawn = blueSlime;
            else if (spawnChance < 83)
                enemySpawn = wizard;
            else if (spawnChance < 97)
                enemySpawn = spider;
            else
                enemySpawn = golem;


            Instantiate(enemySpawn, spawnSpot.transform.position, enemySpawn.transform.rotation);
        }
        wave++;
    }

    void StartGame()
    {
        gameStarted = true;
        startCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }
}
