using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [Header("Weapon")]
    [SerializeField] private Transform Weapon;

    [Header("Bullet")]
    
    [SerializeField] private Transform BulletPoint;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private float SpeedShoot;


    Vector3 ScalePlayerleft = new Vector3(0.4f,0.4f,0f);
    Vector3 ScalePlayerRight = new Vector3(-0.4f, 0.4f, 0);

    private Vector3 dir;
   

    // Update is called once per frame
    void Update()
    {

       Gun();
       if(Input.GetButtonDown("Fire1"))
       {
          
            Shoot();
       }
        
    }
    private void Gun()
    {
        dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        dir = dir.normalized;

        // xử lí xoay súng theo chuột
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        if (gameObject.transform.localScale == ScalePlayerRight)
        {
            Weapon.transform.rotation = Quaternion.Euler(0, 0, angle);

        }
        if (gameObject.transform.localScale == ScalePlayerleft)
        {
            Weapon.transform.rotation = Quaternion.Euler(0, 0, angle+180);
        }

           

    }
    private void Shoot()
    {
        GameObject Bullet;
        
        Bullet = Instantiate(BulletPrefab, BulletPoint.position, Quaternion.identity);
        Bullet.GetComponent<Rigidbody2D>().velocity = dir * SpeedShoot;
    }


}
