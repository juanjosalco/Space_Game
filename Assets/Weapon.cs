using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firepoint;

    [SerializeField] 
    public float fireForce = 20f;

    public void Fire(){
        //Instantiate bullet on firepoint with the same rotation
        GameObject Projectile = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        //Add force to the bullet, Impulse mode since we want it to move right away
        Projectile.GetComponent<Rigidbody2D>().AddForce(firepoint.up * fireForce, ForceMode2D.Impulse);
    }
}
