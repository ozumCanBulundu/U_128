using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Transform karakterTransform;
    public float atesMesafesi = 10f;

    void Update()
    {
        // Raycast ile karakterin baktýðý yönde düþmaný kontrol et
        RaycastHit hit;
        if (Physics.Raycast(karakterTransform.position, karakterTransform.forward, out hit, atesMesafesi))
        {
            // Düþman öldürme iþlemlerini burada gerçekleþtir
            if (hit.transform.CompareTag("Enemy"))
            {
                // Örneðin, düþmanýn oyun nesnesini yok et
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
