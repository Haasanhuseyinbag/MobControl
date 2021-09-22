using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] GameObject Insan, Dev;
    [SerializeField] Transform RayPoint;
    int AtilanInsanSayisi = 0;
    float FireRateTimer, FireRate = 1;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > FireRateTimer)
        {
            Shot();
            AtilanInsanSayisi++;
            FireRateTimer = Time.time + FireRate;
        }
    }
    public void Shot()
    {
        animator.Play("Fire");
        if (AtilanInsanSayisi > 1 && AtilanInsanSayisi % 6 == 0)
            Instantiate(Dev, RayPoint.position, Quaternion.identity);
        else
            Instantiate(Insan, RayPoint.position, Quaternion.identity);
    }
}
