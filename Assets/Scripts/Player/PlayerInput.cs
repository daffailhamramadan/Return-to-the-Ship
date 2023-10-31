using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool SpaceKeyDown()
    {
        return Input.GetKey(KeyCode.Space);

    }

    public float Horizontal
    {
        get;

        private set;
    }

    private void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
    }
}
