using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float _lifetime = 3f;
    private void OnCollisionEnter2D(Collision2D collision){
        Destroy(gameObject);

    }
}
