using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectManager : MonoBehaviour
{
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            other.gameObject.transform.position = transform.position + Vector3.forward;
            Destroy(gameObject.GetComponent<CollectManager>());
            other.gameObject.AddComponent<CollectManager>();
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.AddComponent<NodeMoves>();
            other.gameObject.GetComponent<NodeMoves>().connectedNode = transform;
            other.gameObject.tag = "Collected";
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            playerController.forwardSpeed = 0;
            playerController.horizontalSpeed = 0;
        }
    }

    
}
