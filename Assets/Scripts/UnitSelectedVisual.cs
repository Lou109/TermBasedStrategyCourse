using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelectedVisual : MonoBehaviour
{
 
   [SerializeField] Unit unit;
    MeshRenderer meshRenderer;

    void Awake()

    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

}
