using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Touch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler //Buradaki Interface'ler EvetnSystems k�t�phanesinden geliyor.
{   //OnPointerDown ve OnPointerUp methotlar�n� implamenter etmemizi sa�l�yorlar, bu iki interface eklenince OnPointerDown ve OnPointerUp methotlar� olu�uyor.


    private static bool pressing;
    //Encapsulation (Kaps�lleme) kullan�l�yor.
    //Bu nedenlerle, IsPressing() metodunu ol�u�turduk.
    //Ancak, ihtiya�lara ba�l� olarak pressing de�i�kenini
    //do�rudan kullanmay� tercih edebiliriz. Her iki yakla��m�n da kullan�labilir..
    public static bool IsPressing()
    {
        return pressing;
    }
    public void OnPointerDown(PointerEventData eventData) //Dokunma Durumu
    {
        pressing = true;
    }

    public void OnPointerUp(PointerEventData eventData) //Temas� Kesme Durumu
    {
        pressing = false;
    }
}
