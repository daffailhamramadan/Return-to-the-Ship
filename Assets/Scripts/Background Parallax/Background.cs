using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    [SerializeField] private Transform player;

    private Vector3 velocity = Vector3.zero;

    private Vector3 target;

    void LateUpdate()
    {
        target = new Vector3(player.position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, 0.5f);
    }
}
