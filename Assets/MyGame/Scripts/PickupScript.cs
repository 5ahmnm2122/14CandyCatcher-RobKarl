using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupScript : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] int scoreInt;
    
    void Start()
    {
        scoreText.text = "0";
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Collectible")
        {
            scoreInt = scoreInt + 1;
            scoreText.text = scoreInt.ToString();
            Destroy(other.gameObject);
        }
        if(other.tag=="BadCollectible")
        {
            scoreInt = scoreInt - 1;
            scoreText.text = scoreInt.ToString();
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        //update
    }
}
