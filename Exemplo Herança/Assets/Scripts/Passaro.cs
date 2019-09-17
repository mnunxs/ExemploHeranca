using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passaro : Animal
{
    [SerializeField] string nome;
    public Passaro()
    {
        velocidadeVertical = 5f;
    }

    protected override void Fala() // override = sobrescreve
    {
        base.Fala(); //base pega da classe pai
        Debug.Log("Pássaro: Você disse pipoca?");
    }

    protected override void Move()
    {
        base.Move();
        transform.position += Vector3.up * Mathf.Sin(Time.time); 
        
    }
}
