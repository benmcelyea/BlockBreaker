 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float clampMin = 1f;
    [SerializeField] float clampMax = 15f;

    float mousePosInUnits;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits ;
        Vector2 PaddlePos = new Vector2(transform.position.x, transform.position.y);
        PaddlePos.x = Mathf.Clamp(mousePosInUnits, clampMin, clampMax);
        transform.position = PaddlePos;

    }
}
