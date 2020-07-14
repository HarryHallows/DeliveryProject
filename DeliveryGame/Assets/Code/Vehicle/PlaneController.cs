using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{

    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InputControl();
        MovementControl();
    }

    void InputControl()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


    }

    void MovementControl()
    {
        transform.Rotate(vertical, 0, -horizontal);
    }

}
