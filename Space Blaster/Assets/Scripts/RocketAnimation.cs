using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAnimation : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite oldSprite;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        if ((int)(Time.deltaTime) % 2 == 0) {
            spriteRenderer.sprite = newSprite;
        } else if ((int)(Time.deltaTime) % 2 == 1) {
            spriteRenderer.sprite = oldSprite;
        }

    }
}

