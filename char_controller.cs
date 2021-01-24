using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updowncontrol : MonoBehaviour
{
  public float speed;
  private Rigidbody2D rb;
  private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      //moving character
      Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
      moveVelocity = moveInput.normalized * speed;
    }
    void FixedUpdate()
    // keep moving if move button keep pressed
    {
      rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
