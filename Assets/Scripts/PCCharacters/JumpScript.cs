using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    private float fallMultiplier = 2.5f;
    private float lowJumpMultiplier = 2.0f;

    private Rigidbody2D rbReference;

    private void Awake()
    {
        rbReference = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (rbReference.velocity.y <= 0)
        {
            rbReference.velocity += Vector2.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rbReference.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rbReference.velocity += Vector2.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

}
