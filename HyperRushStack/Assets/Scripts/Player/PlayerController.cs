using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float horizontalMoveSpeed;
    [SerializeField] private float forwardMoveSpeed;

    public float horizontalSpeed
    {
        get { return horizontalMoveSpeed; }
        set { horizontalMoveSpeed = value; }
    }
    public float forwardSpeed
    {
        get { return forwardMoveSpeed; }
        set { forwardMoveSpeed = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHorizontalInput();
        transform.Translate(new Vector3(horizontalInput * horizontalMoveSpeed * Time.deltaTime, 0 ,forwardMoveSpeed * Time.deltaTime));
    }

    private void PlayerHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizontalInput = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontalInput = 0;
        }
    }

}
