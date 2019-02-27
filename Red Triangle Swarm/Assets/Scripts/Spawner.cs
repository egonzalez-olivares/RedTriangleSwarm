using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject triangle;
    private float floatSecs;
    private int intSecs;
    private int numOfTriangles;

    private GameManager gameManager;

    void Start()
    {
        InvokeRepeating("SpawnTriangle", 5.0f, 2.0f);
        floatSecs = 0.0f;
        numOfTriangles = 0;

        GameObject gameManagerObject = GameObject.FindWithTag("GameController");
        if (gameManagerObject != null)
        {
            gameManager = gameManagerObject.GetComponent<GameManager>();
        }
        else
        {
            Debug.Log("Cannot find 'GameManager' script");
        }
    }

    void SpawnTriangle()
    {
        GameObject triangleInstance = Instantiate(triangle);
        triangleInstance.transform.position = transform.position;
        // count number of triangles spawned
        numOfTriangles++;
    }

    void Update()
    {
        floatSecs += Time.deltaTime;
        intSecs = (int)floatSecs;
        
        if (numOfTriangles == 10 || gameManager.gameOver)
        {
            CancelInvoke();
        }
    }

    
}
