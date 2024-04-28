using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float parallaxSpeed;
    private float spriteHeight;
    private Vector3 startPos;
       
    void Start()
    {
        startPos = transform.position;
        spriteHeight = GetComponent<SpriteRenderer>().bounds.size.y;
        
    }


    void Update()
    {
        
    }
}
