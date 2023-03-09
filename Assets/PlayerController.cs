using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;

    public Rigidbody2D rb;
    public Weapon weapon;

    Vector2 moveDirection;
    Vector2 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Horizontal");

        if(Input.GetMouseButtonDown(0)){
            weapon.Fire();
        }

        moveDirection = new Vector2(horizontal, vertical).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate(){
        rb.velocity = new Vector2(moveDirection.x * _speed, moveDirection.y * _speed);

        Vector2 aimDirection = mousePosition - rb.position;
        float _angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = _angle;
    }
}
