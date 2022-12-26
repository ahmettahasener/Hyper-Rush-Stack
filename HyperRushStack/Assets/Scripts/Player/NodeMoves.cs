using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMoves : MonoBehaviour
{
    public Transform connectedNode;
    [SerializeField] private float nodeSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, connectedNode.position.x, nodeSpeed * Time.deltaTime) , connectedNode.position.y , connectedNode.position.z + 1);
    }
}
