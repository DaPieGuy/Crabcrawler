using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCheck : MonoBehaviour
{
    public PlayerController script;
    private Collider2D RightCollider;
    [SerializeField] LayerMask groundLayer;

    void Start() {
        script.rightCheck = false;
        RightCollider = GetComponent<Collider2D>();
    }
    
    void FixedUpdate() {
        script.rightCheck = Physics2D.BoxCast(RightCollider.bounds.center, RightCollider.bounds.size, 0f, Vector2.right, 0f, groundLayer);
    }
}
