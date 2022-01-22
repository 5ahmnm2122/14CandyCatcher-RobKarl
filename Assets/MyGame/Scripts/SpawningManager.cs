using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawningManager : MonoBehaviour
{
    [SerializeField] GameObject[] fruitPrefab;
    [SerializeField] float respawnTime;
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
        spawningArea.transform.position = new Vector2(Random.Range(-screenBounds.x + 1, screenBounds.x - 1), screenBounds.y * 2);
    }
    IEnumerator fruitWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnFruits();
        }
    }
}
