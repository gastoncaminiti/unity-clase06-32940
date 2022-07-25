using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 2f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //Método para mover el trasform usando la posicion.
    private void Move()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
