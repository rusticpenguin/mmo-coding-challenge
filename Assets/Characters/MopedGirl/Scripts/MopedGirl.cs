using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MopedGirl : MonoBehaviour
{
    [SerializeField] int health = 12;
    [SerializeField] int exp = 0;

    float accel = 0f;
    [SerializeField] float currentYSpeed = 0f;
    [SerializeField] float maxYSpeed = 4f;
    [SerializeField] float xSpeed = 2f;

    void Update()
    {
        VerticalMovement();
    }

    void VerticalMovement ()
    {
        if (currentYSpeed < maxYSpeed)
        {
            currentYSpeed += accel;
        }

        transform.Translate(Vector3.up * currentYSpeed * Time.deltaTime);
    }

    void IncreaseExp(int experience)
    {
        exp += experience;
    }
}
