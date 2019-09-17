﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    
    [SerializeField] protected float velocidadeVertical;

    Vector3 posicaoInicial;
    Vector3 posicao;

    private void Start()
    {
        posicaoInicial = transform.position;
    }

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {

        //faz um senoide
        posicao = posicaoInicial + Vector3.right * Mathf.Sin(Time.time); //up ou down = pra cima e pra baixo
        if (velocidadeVertical > 0)
            velocidadeVertical -= 14 * Time.deltaTime;
        
        if (velocidadeVertical < 0)
            velocidadeVertical = 0;

        posicao.y = velocidadeVertical + posicao.y;
        
        transform.position = posicao;
    }
    
    protected virtual void Fala()
    {
        Debug.Log("O animal diz: ");
    }

    protected virtual void Pula()
    {
        velocidadeVertical = 2.0f;
    }
}
