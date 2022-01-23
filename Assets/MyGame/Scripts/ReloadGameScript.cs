using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReloadGameScript : MonoBehaviour
{
    public PickupScript pickupScriptVar;
    public SceneSwitchScript sceneSwitchScripter;
    [SerializeField] Text scorePlusNameText;
    void Start()
    {
        // scorePlusNameText.text = "Test";
        pickupScriptVar = GameObject.FindGameObjectWithTag("PickupScriptHolder").GetComponent<PickupScript>();
        sceneSwitchScripter = GameObject.FindGameObjectWithTag("SceneSwitchBoi").GetComponent<SceneSwitchScript>();
        scorePlusNameText.text = pickupScriptVar.scoreInt.ToString() + ", " + sceneSwitchScripter.playerNameText;
        // Debug.Log(pickupScriptVar.scoreInt.ToString());
        // scorePlusNameText.text = sceneSwitchScripter.playerNameText + ", " + pickupScriptVar.scoreInt.ToString();
    }
    public void ReloadMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
