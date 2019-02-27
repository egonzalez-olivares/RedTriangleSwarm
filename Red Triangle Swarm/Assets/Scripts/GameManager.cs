using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Text endGameText;
    public Text restartText;
    
    [HideInInspector]public bool gameOver;

	// Use this for initialization
	void Start () {
        gameOver = false;
        endGameText.text = "";
        restartText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver)
        {
            restartText.text = "Press 'R' to restart";
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
	}

    public void WinGame()
    {
        endGameText.text = "You Win!";
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        gameOver = true;
    }

    public void LoseGame()
    {
        endGameText.text = "You Lose";
        gameOver = true;
    }
}
