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
        // bu kod, bir oyun nesnesinin dönüþ
        // açýsýný belirli bir sýnýra (25 derece)
        // sýnýrlamak için kullanýlýr.Sebebi kullandýðýmýz meshin alt kýsmý yok sadece yarým silindir þeklinde olmasýndandýr.
    }
}
