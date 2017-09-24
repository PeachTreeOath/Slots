using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelSwitch : MonoBehaviour {

    public bool isDirectionUp;

    private Sprite normalSprite;
    private Sprite hoverSprite;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        normalSprite = spriteRenderer.sprite;
        if(isDirectionUp)
            hoverSprite = ResourceLoader.instance.GetSprite("reelUpHover");
        else
            hoverSprite = ResourceLoader.instance.GetSprite("reelDownHover");
    }

    void OnMouseDown()
    {
        Debug.Log("IWJER");
    }

    void OnMouseEnter()
    {
        spriteRenderer.sprite = hoverSprite;
    }

    void OnMouseExit()
    {
        spriteRenderer.sprite = normalSprite;
    }
}
