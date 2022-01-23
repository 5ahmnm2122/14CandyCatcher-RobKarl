using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] int timeInt;
    [SerializeField] GameObject basketMonkey;
    void Start()
    {
        timerText.text = timeInt.ToString();
        StartCoroutine(timer());
    }

    

    public void TimerCalculation()
    {
        timeInt = timeInt - 1;
    }

    IEnumerator timer()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            TimerCalculation();
        }
    }
    public void AddTime()
    {
        timeInt = timeInt + 2;
    }
    public void RemoveTime()
    {
        timeInt = timeInt - 5;
    }
    
    
    void Update()
    {
        //Game Over
        timerText.text = timeInt.ToString() + "s";
        if(timeInt<=0)
        {
            // Debug.Log("GameOver");
            basketMonkey.transform.DetachChildren();
            Destroy(basketMonkey);
            StopAllCoroutines();
            SceneManager.LoadScene(2);
        }
    }
}
