using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawningManager : MonoBehaviour
{
    [SerializeField] GameObject[] fruitPrefab;
    [SerializeField] Sprite[] spawnableFruits;
    [SerializeField] Vector2 screenBounds;

    void Start()
    {
        int arrayIndex = Random.Range(0, fruitPrefab.Length);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        Debug.Log(arrayIndex.ToString());
    }

    void Update()
    {

    }


    // void Start()
    // {
    //     // StartCoroutine(SpawnObjects());
    // }

    // private IEnumerator SpawnObjects()
    // {
    //         Debug.Log("Coroutine Started");
    //         // Instantiate(spawnableFruits[Random.RandomRange(0,4)], new Vector2(spawnPoints[Random.Range(0, 8)].transform.position.x, 80, 90), transform.rotation);
    // }
}
