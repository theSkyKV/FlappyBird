using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private int _score;

    private void Start()
    {
        _score = 0;
    }

    public void Die()
    {
        Debug.Log("aaaa");
        Time.timeScale = 0;
    }

    public void AddScore()
    {
        _score++;
    }
}
