using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 screenBounds;
    [SerializeField] GameObject playerGO;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        // playerGO.GetComponent<CapsuleCollider2D>;
        // Debug.Log(screenBounds.ToString());
        // Debug.Log(Screen.width.ToString());
        // Debug.Log(Screen.height.ToString());
    }

    void Update()
    {
        

        if(transform.position.y < -screenBounds.y*1.5)
        {
            Destroy(this.gameObject);
        }
    }
}