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
        // Yatay eksende input al (sol ve sað ok tuþlarýyla)
        float hareket = Input.GetAxis("Horizontal") * hiz * Time.fixedDeltaTime;

        // Yeni pozisyon hesapla
        Vector3 yeniPozisyon = transform.position + new Vector3(hareket, 0, 0);

        // Raketin sahne dýþýna çýkmasýný engelle
        yeniPozisyon.x = Mathf.Clamp(yeniPozisyon.x, sinirSol, sinirSag);

        // Raketin pozisyonunu güncelle
        transform.position = yeniPozisyon;
    }
}
