using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] bool isPlayerOne;

    Vector3 startPoint;
    Rigidbody2D rb;
    float movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPoint = transform.position;
    }

    private void Update()
    {
        if (isPlayerOne) movement = Input.GetAxis("Vertical");
        else movement = Input.GetAxis("Vertical2");
        rb.velocity = new Vector2(0, movement * Speed);
    }

    public void Reset()
    {
        transform.position = startPoint;
    }
}
