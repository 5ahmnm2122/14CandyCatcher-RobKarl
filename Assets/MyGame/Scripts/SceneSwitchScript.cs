using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitchScript : MonoBehaviour
{
    [SerializeField] Text inputField;
    [SerializeField] Text disclaimerText;
    public string playerNameText;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
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
        playerNameText = inputField.text;
        }
        // Debug.Log("SceneSwitch");
    }
}
