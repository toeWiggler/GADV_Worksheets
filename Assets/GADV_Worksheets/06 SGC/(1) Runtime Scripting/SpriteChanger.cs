using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite newSprite;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (newSprite != null)
        {
            spriteRenderer.sprite = newSprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
