using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitchScript : MonoBehaviour
{
    [SerializeField] Text inputField;
    [SerializeField] Text disclaimerText;
    // [SerializeField] GameManager gameManagerScript;
    // public static string playerName;
    public void SceneSwitch()
    {
        if(inputField.text=="")
        {
            // Debug.Log("Input Field empty");
            disclaimerText.text = "Please enter a valid name";
        }
        else
        {
        SceneManager.LoadScene(1);
        // playerName = inputField.text;
        }
        // Debug.Log("SceneSwitch");
    }
}
