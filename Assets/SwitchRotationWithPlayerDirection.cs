using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRotationWithPlayerDirection : MonoBehaviour
{

    public PlayerMovement playerMovement;


    void Update()
    {
        Vector2 direction = playerMovement.direction;

        if (direction == Vector2.up)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else if (direction == Vector2.left)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
        }
        else if (direction == Vector2.down)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 180));
        }
        else if (direction == Vector2.right)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 270));
        }

    }
}
