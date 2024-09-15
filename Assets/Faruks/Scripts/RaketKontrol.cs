using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaketKontrol : MonoBehaviour
{
    public float hiz = 10f;
    public float sinirSol = -8f;
    public float sinirSag = 8f;

    void FixedUpdate()
    {
        // Yatay eksende input al (sol ve sa� ok tu�lar�yla)
        float hareket = Input.GetAxis("Horizontal") * hiz * Time.fixedDeltaTime;

        // Yeni pozisyon hesapla
        Vector3 yeniPozisyon = transform.position + new Vector3(hareket, 0, 0);

        // Raketin sahne d���na ��kmas�n� engelle
        yeniPozisyon.x = Mathf.Clamp(yeniPozisyon.x, sinirSol, sinirSag);

        // Raketin pozisyonunu g�ncelle
        transform.position = yeniPozisyon;
    }
}
