using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixCylinder : MonoBehaviour
{
    private GameObject helix;

    private void Awake()
    {
        helix = GameObject.Find("Helix");
    }
    private void Update()
    {
        transform.eulerAngles=new Vector3(0,0,helix.gameObject.transform.eulerAngles.z %25);
        // bu kod, bir oyun nesnesinin d�n��
        // a��s�n� belirli bir s�n�ra (25 derece)
        // s�n�rlamak i�in kullan�l�r.Sebebi kulland���m�z meshin alt k�sm� yok sadece yar�m silindir �eklinde olmas�ndand�r.
    }
}
