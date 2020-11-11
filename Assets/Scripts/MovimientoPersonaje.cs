﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float speed = 1f;
    public Vector2 direccion;
    private Vector2 movimiento;
    private Animator animator;

    // Start is called before the first frame update

    void Awake()
    {
        animator = GetComponent<Animator>();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        
        movimiento = new Vector2(horizontalInput, verticalInput);
        if(horizontalInput != 0)
        {
            if(horizontalInput > 0)
            {
                //animator.SetInteger("Movimiento", 4);
                animator.SetTrigger("Derecha");
            } else
            {
                //animator.SetInteger("Movimiento", 3);
                animator.SetTrigger("Izquierda");
            }
        } else if(verticalInput != 0)
        {
            if(verticalInput > 0)
            {
                //animator.SetInteger("Movimiento", 1);
                animator.SetTrigger("Arriba");
            }
            else
            {
                //animator.SetInteger("Movimiento", 2);
                animator.SetTrigger("Abajo");
            }
        }
        transform.Translate(movimiento); 
    }

}