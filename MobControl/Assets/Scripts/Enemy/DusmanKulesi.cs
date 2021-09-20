using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanKulesi : MonoBehaviour
{
    public int Healt;
    [SerializeField] TextMesh HealtText;
    [SerializeField] GameObject Insan, Dev;
    [SerializeField] Transform RayPoint, RayPoint1, RayPoint2;
    [SerializeField] float FireRateMin, FireRateMax;
    int AtilanInsanSayisi = 0;
    float FireRateTimer, FireRate;
    int DevAtilmaZamani;
    GameManager manager;
    private void Start()
    {
        Time.timeScale = 1;
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
            HealtText.text = Healt.ToString();
            if (Healt <= 0)
            {
                manager.Win();
                HealtText.text = "0";
            }
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
            Instantiate(Dev, RayPoint1.position, new Quaternion(0, 180, 0, transform.rotation.w));
            Instantiate(Dev, RayPoint2.position, new Quaternion(0, 180, 0, transform.rotation.w));
            AtilanInsanSayisi = 0;
        }
        else
        {
            Instantiate(Insan, RayPoint.position, new Quaternion(0, 180, 0, transform.rotation.w));
            Instantiate(Insan, RayPoint1.position, new Quaternion(0, 180, 0, transform.rotation.w));
            Instantiate(Insan, RayPoint2.position, new Quaternion(0, 180, 0, transform.rotation.w));
        }
        FireRate = Random.Range(FireRateMin, FireRateMax);
        DevAtilmaZamani = Random.Range(7, 10);
    }
}
