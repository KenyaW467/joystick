using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 0.01f;
    public bool pc_mode = false;
    //public VariableJoystick variableJoystick;
    public FloatingJoystick variableJoystick;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (pc_mode == false)
        {
            //Vector3 pos = transform.position;
            //pos.x += variableJoystick.Horizontal * speed;
            //pos.y += variableJoystick.Vertical * speed;
            transform.Translate(variableJoystick.Horizontal * speed, variableJoystick.Vertical * speed, 0);
        }
        else
        {
            if (Input.GetKey("up"))
            {
                //transform.position += transform.forward * speed * 50 * Time.deltaTime;
                transform.Translate(0, 1 * speed, 0);
            }
            if (Input.GetKey("down"))
            {
                //transform.position -= transform.forward * speed * 50 * Time.deltaTime;
                transform.Translate(0, -1 * speed, 0);
            }
            if (Input.GetKey("right"))
            {
                //transform.position += transform.right * speed * 50 * Time.deltaTime;
                transform.Translate(1 * speed, 0, 0);
            }
            if (Input.GetKey("left"))
            {
                //transform.position -= transform.right * speed * 50 * Time.deltaTime;
                transform.Translate(-1 * speed, 0, 0);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("何かにあたった！");
    }
}
