using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] float ballSpeed;
    Rigidbody2D rb;
    Vector3 startPoint;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        startPoint = transform.position;
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }


    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(x * ballSpeed, y * ballSpeed);
    }

    public void Reset()
    {
        transform.position = startPoint;
        Launch();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audio.Play();
    }
}
