using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peixe : Animal
{
    [SerializeField] string nome;

    protected override void Fala()
    {
        
        Debug.Log("Peixe: *PEIXE NÃO FALA*");
    }
}
