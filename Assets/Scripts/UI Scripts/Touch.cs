using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Touch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler //Buradaki Interface'ler EvetnSystems kütüphanesinden geliyor.
{   //OnPointerDown ve OnPointerUp methotlarýný implamenter etmemizi saðlýyorlar, bu iki interface eklenince OnPointerDown ve OnPointerUp methotlarý oluþuyor.


    private static bool pressing;
    //Encapsulation (Kapsülleme) kullanýlýyor.
    //Bu nedenlerle, IsPressing() metodunu olþuþturduk.
    //Ancak, ihtiyaçlara baðlý olarak pressing deðiþkenini
    //doðrudan kullanmayý tercih edebiliriz. Her iki yaklaþýmýn da kullanýlabilir..
    public static bool IsPressing()
    {
        return pressing;
    }
    public void OnPointerDown(PointerEventData eventData) //Dokunma Durumu
    {
        pressing = true;
    }

    public void OnPointerUp(PointerEventData eventData) //Temasý Kesme Durumu
    {
        pressing = false;
    }
}
