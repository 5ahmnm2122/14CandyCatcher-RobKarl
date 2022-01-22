using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReloadGameScript : MonoBehaviour
{
    public void ReloadMainScene()
    {
        SceneManager.LoadScene(1);
    }
}
