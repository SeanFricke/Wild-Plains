using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public SlimeBehavior slimeBehavior;

    Vector2 RightAttackOffset;

    public Collider2D SwordCollider;


    private void Start()
    {
        SwordCollider = GetComponent<Collider2D>();
        RightAttackOffset = transform.position;
        SwordCollider.enabled = false;
    }


    public void AttackLeft()
    {
        SwordCollider.enabled = true;
        transform.position = new Vector2(RightAttackOffset.x * -1, RightAttackOffset.y);
        print("left");
    }

    // Update is called once per frame
    public void AttackRight()
    {
        SwordCollider.enabled = true;
        print("right");
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy" && SwordCollider.enabled == true)
        {
            slimeBehavior.Damage();
        }
    }

}