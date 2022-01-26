using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;

    private Vector3 velocity = Vector3.zero;

    private Vector3 target;

    private float offset = 2f;

    // Update is called once per frame
    void LateUpdate()
    {
        target = new Vector3(player.position.x, player.position.y + offset, transform.position.z);

        transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, 0.5f);
    }
}
