using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Transform karakterTransform;
    public float atesMesafesi = 10f;

    void Update()
    {
        // Raycast ile karakterin bakt��� y�nde d��man� kontrol et
        RaycastHit hit;
        if (Physics.Raycast(karakterTransform.position, karakterTransform.forward, out hit, atesMesafesi))
        {
            // D��man �ld�rme i�lemlerini burada ger�ekle�tir
            if (hit.transform.CompareTag("Enemy"))
            {
                // �rne�in, d��man�n oyun nesnesini yok et
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
