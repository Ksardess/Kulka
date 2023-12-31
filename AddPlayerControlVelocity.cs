using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;
    [SerializeField]
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(keyPositive))
                GetComponent<Rigidbody>().velocity += v3Force;

            if (Input.GetKey(keyNegative))
                GetComponent<Rigidbody>().velocity -= v3Force;
        }
}


