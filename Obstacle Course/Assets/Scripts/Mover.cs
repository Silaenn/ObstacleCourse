using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    void Start()
    {
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float zValue = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        transform.Translate(xValue, 0, zValue);
    }
}
