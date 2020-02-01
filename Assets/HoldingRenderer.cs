using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingRenderer : MonoBehaviour
{

    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Holding holding = transform.parent.gameObject.GetComponentInParent<Holding>();
        if (holding != null)
        {
            sr.sprite = Item.getSpriteByItemId(holding.itemId);
        }
    }
}
