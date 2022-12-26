using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform moneyTransform;

    private Vector3 newPosition;
    private Vector3 offset;

    [SerializeField] private float lerpValue;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - moneyTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        FollowCamera();
    }

    private void FollowCamera()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, moneyTransform.position.y, moneyTransform.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
