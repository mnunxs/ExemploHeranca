using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peixe : Animal
{
    [SerializeField] string nome;

    protected override void Fala()
    {
        base.Fala();
        Debug.Log("Peixe: *PEIXE NÃO FALA*");
    }
}
