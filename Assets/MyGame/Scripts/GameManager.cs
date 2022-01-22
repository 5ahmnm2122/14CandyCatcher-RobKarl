using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] Sprite playerGO;
    [SerializeField] Vector2 playerSpeed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 negativePlayerSpeed;
    [SerializeField] Text playerNameTextGO;
    public SceneSwitchScript sceneSwitchScripter;

    void Start()
    {
        negativePlayerSpeed = playerSpeed*-1;
        sceneSwitchScripter = GameObject.FindGameObjectWithTag("SceneSwitchBoi").GetComponent<SceneSwitchScript>();
        playerNameTextGO.text = sceneSwitchScripter.playerNameText;
    }
    void Update() 
    {
        //Input for left movement
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Debug.Log("A wird gedrueckt");
            rb.AddForce(negativePlayerSpeed, ForceMode2D.Force);

        }

        //Input for right movement
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Debug.Log("D wird gedrueckt");
            rb.AddForce(playerSpeed, ForceMode2D.Force);
        }
    }

}
