using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 5.0f;

    public GameObject player;

    private void FixedUpdate()
    {
        Vector3 dir = player.transform.position - this.transform.position;
        if(dir.x > 0)
        {
            Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, 0, 0.0f);
            this.transform.Translate(moveVector);
        }

    }
}
