using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helix : MonoBehaviour
{
    private bool movable = true;
    private float angle; //Açý
    private float lastDeltaAngle, lastTouchX; //Önceki delta açýsý ve dokunulan X noktasý

    void Update()
    {
        if (movable && Touch.IsPressing()) //Hareket izni varsa ve ekrana dokunuluyorsa
        {
            //bu kod parçasý kullanýcýlarýn dokunmatik
            //ekran üzerinde nesneyi döndürmelerine veya
            //açýyý deðiþtirmelerine olanak tanýr
            float mouseX = this.GetMouseX();
            lastDeltaAngle=lastTouchX - mouseX;
            //Hareket hýzýný veya yönünün belirlenmesi için bu fark alýnýr.
            angle += lastDeltaAngle * 360 * 1.7f;
            //Nesnesnin dönüþ açýsýný günceller. 360 tam turu 1.7 de hýzýný simüle etmek için.
            lastTouchX = mouseX;
        }
        else if(lastDeltaAngle != 0)
        {
            lastDeltaAngle -=lastDeltaAngle *5 *Time.deltaTime;
            //Bu satýr, önceki dokunmatik veya fare pozisyon farkýný
            //hýzla sýfýra yaklaþtýrmak için kullanýlýr. 
            //Yani, kullanýcý bir hareket yapmýþsa ve þimdi hareket yapmýyorsa,
            //bu kod parçasý, hareketi yavaþça durdurur. 
            angle += lastDeltaAngle * 360 * 1.7f;
            //. Bu, kullanýcýnýn daha önce yapmýþ olduðu dönüþ
            //hareketini yavaþça sýfýrlamak yerine, bu hareketi
            //hala takip etmeye devam eder. 
        }
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    private float GetMouseX()
    {
        return Input.mousePosition.x / (float) Screen.width;
        //X posizyonu aldýk ancak ekran geniþliðine böldük 
        //Bu iþlem, fare pozisyonunu ekranýn yatay koordinatlarýna göre normalleþtirir,
        //böylece herhangi bir ekran boyutunda veya çözünürlüðünde doðru sonuç elde edebilirsiniz.
    }
}
