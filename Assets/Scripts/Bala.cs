using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float speed = 2f;
    public Vector2 direccion;

    public float tiempoVIda = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tiempoVIda);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = direccion.normalized * speed * Time.deltaTime;

        transform.Translate(movimiento);
    }
}
