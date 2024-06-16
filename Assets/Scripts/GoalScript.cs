using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    [SerializeField] bool isPlayerOneGoal;
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Ball")
        {
            audio.Play();
            if (isPlayerOneGoal) GameManager.main.PlayerOneScore();
            else GameManager.main.PlayerTwoScore();
        }
    }
}
