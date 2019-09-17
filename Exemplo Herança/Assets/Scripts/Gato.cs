using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gato : Animal
{
    [SerializeField] string nome;
    protected override void Fala()
    {
        base.Fala();
        Debug.Log("Gato: Pegue o passaro!!!");
    }
}
