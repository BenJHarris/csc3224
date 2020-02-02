using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour

{

    public PlayerMovement mvmt;
    public CapsuleCollider2D col;


    void Update()
    {
        if (Input.GetKeyDown("e")) {

            // cast ray from base of character 
            RaycastHit2D hit = Physics2D.Raycast(
            transform.position +
            new Vector3(col.offset.x, col.offset.y, 0),
            mvmt.direction, 0.4f);

            if (hit)
            {
                Interactable interactable = hit.collider.gameObject.GetComponent<Interactable>();
                if (interactable != null)
                {
                    interactable.Interact();
                }
            }

        }
    }
}
