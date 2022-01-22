using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickupScript : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] int scoreInt;
    public TimeManager timeManagerScript;
    // public SceneSwitchScript sceneSwitchScriptBoiii;
    
    void Start()
    {
        scoreText.text = "0";
        // sceneSwitchScriptBoiii = GameObject.FindGameObjectWithTag("SceneSwitchBoi").GetComponent<SceneSwitchScript>();
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        //Good Pickups
        if(other.tag=="Collectible")
        {
            scoreInt = scoreInt + 1;
            scoreText.text = scoreInt.ToString();
            timeManagerScript.AddTime();
            Destroy(other.gameObject);
        }
        //Bad Pickups
        if(other.tag=="BadCollectible")
        {
            scoreInt = scoreInt - 1;
            scoreText.text = scoreInt.ToString();
            timeManagerScript.RemoveTime();
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        //losing
        if(scoreInt<=-1)
        {
            SceneManager.LoadScene(2);
        }
    }
}
