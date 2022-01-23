using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReloadGameScript : MonoBehaviour
{
    public GameObject pickupScriptVar;
    public GameObject sceneSwitchScripter;
    [SerializeField] Text scorePlusNameText;
    void Start()
    {
        //searches for static objects and assigns them to variable
        pickupScriptVar = GameObject.FindGameObjectWithTag("PickupScriptHolder");
        sceneSwitchScripter = GameObject.FindGameObjectWithTag("SceneSwitchBoi");
        // scorePlusNameText.text = pickupScriptVar.scoreInt.ToString() + ", " + sceneSwitchScripter.playerNameText;
        scorePlusNameText.text = "Score: " + pickupScriptVar.GetComponent<PickupScript>().scoreInt.ToString() + ", Name: " + sceneSwitchScripter.GetComponent<SceneSwitchScript>().playerNameText;
    }
    public void ReloadMainScene()
    {
        Destroy(pickupScriptVar);
        Destroy(sceneSwitchScripter);
        SceneManager.LoadScene(0);
    }
}
