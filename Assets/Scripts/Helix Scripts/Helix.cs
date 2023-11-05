using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helix : MonoBehaviour
{
    private bool movable = true;
    private float angle; //A��
    private float lastDeltaAngle, lastTouchX; //�nceki delta a��s� ve dokunulan X noktas�

    void Update()
    {
        if (movable && Touch.IsPressing()) //Hareket izni varsa ve ekrana dokunuluyorsa
        {
            //bu kod par�as� kullan�c�lar�n dokunmatik
            //ekran �zerinde nesneyi d�nd�rmelerine veya
            //a��y� de�i�tirmelerine olanak tan�r
            float mouseX = this.GetMouseX();
            lastDeltaAngle=lastTouchX - mouseX;
            //Hareket h�z�n� veya y�n�n�n belirlenmesi i�in bu fark al�n�r.
            angle += lastDeltaAngle * 360 * 1.7f;
            //Nesnesnin d�n�� a��s�n� g�nceller. 360 tam turu 1.7 de h�z�n� sim�le etmek i�in.
            lastTouchX = mouseX;
        }
        else if(lastDeltaAngle != 0)
        {
            lastDeltaAngle -=lastDeltaAngle *5 *Time.deltaTime;
            //Bu sat�r, �nceki dokunmatik veya fare pozisyon fark�n�
            //h�zla s�f�ra yakla�t�rmak i�in kullan�l�r. 
            //Yani, kullan�c� bir hareket yapm��sa ve �imdi hareket yapm�yorsa,
            //bu kod par�as�, hareketi yava��a durdurur. 
            angle += lastDeltaAngle * 360 * 1.7f;
            //. Bu, kullan�c�n�n daha �nce yapm�� oldu�u d�n��
            //hareketini yava��a s�f�rlamak yerine, bu hareketi
            //hala takip etmeye devam eder. 
        }
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    private float GetMouseX()
    {
        return Input.mousePosition.x / (float) Screen.width;
        //X posizyonu ald�k ancak ekran geni�li�ine b�ld�k 
        //Bu i�lem, fare pozisyonunu ekran�n yatay koordinatlar�na g�re normalle�tirir,
        //b�ylece herhangi bir ekran boyutunda veya ��z�n�rl���nde do�ru sonu� elde edebilirsiniz.
    }
}
