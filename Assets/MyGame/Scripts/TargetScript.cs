using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    // [SerializeField] float speed = 10;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 screenBounds;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        // rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    void Update()
    {
        if(transform.position.y < screenBounds.x)
        {
            Destroy(this.gameObject);
        }
    }
}