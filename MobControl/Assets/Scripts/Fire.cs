using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] GameObject Insan, Dev;
    [SerializeField] Transform RayPoint;
    CannonScript cannon = new CannonScript();
    int AtilanInsanSayisi = 0;
    float FireRateTimer;
    void Start()
    {
        cannon.FireRate = 0.5f;
    }
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > FireRateTimer)
        {
            Shot();
            AtilanInsanSayisi++;
            FireRateTimer = Time.time + cannon.FireRate;
        }
    }
    public void Shot()
    {
        if (AtilanInsanSayisi > 1 && AtilanInsanSayisi % 6 == 0)
            Instantiate(Dev, RayPoint.position, transform.rotation);
        else
            Instantiate(Insan, RayPoint.position, transform.rotation);
    }
}
