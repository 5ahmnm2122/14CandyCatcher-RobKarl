using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawningManager : MonoBehaviour
{
    [SerializeField] GameObject[] fruitPrefab;
    [SerializeField] float respawnTime = 1.0f;
    [SerializeField] Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        StartCoroutine(fruitWave());
    }
    private void SpawnFruits()
    {
        int arrayIndex = Random.Range(0, fruitPrefab.Length);
        // Debug.Log(arrayIndex.ToString());
        GameObject spawningArea = Instantiate(fruitPrefab[arrayIndex]) as GameObject;
        spawningArea.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    IEnumerator fruitWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnFruits();
        }
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
