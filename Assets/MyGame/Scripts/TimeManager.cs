using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] int timeInt;
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
    
    void Update()
    {
        timerText.text = timeInt.ToString() + "s";
    }
}
