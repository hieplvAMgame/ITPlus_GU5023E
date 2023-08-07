using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public float moveSpeed;

    private Vector3 dir, vel;
    private float x, y;
    private const string Hor = "Horizontal";
    private const string Ver = "Vertical";
    private const string Move = "isMove";

    private void Update()
    {
        x = Input.GetAxis(Hor);
        y = Input.GetAxis(Ver);

        dir = new Vector3(x, y);
        vel = dir.normalized * moveSpeed;
    }
    private void FixedUpdate()
    {
        if (dir.magnitude > .1f)
        {
            //Cho player di chuyen
            rb.velocity = vel * Time.fixedDeltaTime;
        }
        else
            rb.velocity = Vector2.zero;
        Animate(dir.magnitude > .1f);
        if (x > 0)
            transform.eulerAngles = Vector3.zero;
        else if (x < 0)
            transform.eulerAngles = Vector3.up * 180;
    }
    private void Animate(bool isMove)
    {
        anim.SetBool(Move, isMove);
    }
}
