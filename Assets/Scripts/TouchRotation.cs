using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotation : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPosition;
    private Quaternion rotationY;
    private float rotationSpeedModifier = 0.2f;
    private float movementSpeedModifier = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
        touch = Input.GetTouch(0);
        if(touch.phase == TouchPhase.Moved)
        {
            rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotationSpeedModifier, 0f);
           
        transform.position = new Vector3(
        //transform.position.x + touch.deltaPosition.x * movementSpeedModifier,   messing up movement
        transform.position.x,
        transform.position.y+ touch.deltaPosition.y * movementSpeedModifier,
        transform.position.z );
        
         transform.rotation = rotationY * transform.rotation;
        }



         }
    }
}
