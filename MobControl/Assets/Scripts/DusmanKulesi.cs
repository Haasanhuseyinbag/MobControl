using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanKulesi : MonoBehaviour
{
    [SerializeField] GameObject Insan, Dev;
    [SerializeField] Transform RayPoint;
    [SerializeField] float FireRateMin,FireRateMax;
    int AtilanInsanSayisi = 0;
    float FireRateTimer, FireRate;
    int DevAtilmaZamani;
    void Update()
    {
        if (Time.time > FireRateTimer)
        {
            Shot();
            AtilanInsanSayisi++;
            FireRateTimer = Time.time + FireRate;
        }
    }
    public void Shot()
    {
        if (AtilanInsanSayisi > 1 && AtilanInsanSayisi % DevAtilmaZamani == 0)
        {
            Instantiate(Dev, RayPoint.position, new Quaternion(0, 180, 0, transform.rotation.w));
            AtilanInsanSayisi = 0;
        }
        else
            Instantiate(Insan, RayPoint.position, new Quaternion(0, 180, 0, transform.rotation.w));
        FireRate = Random.Range(FireRateMin, FireRateMax);
        DevAtilmaZamani = Random.Range(5, 8);
    }
}
