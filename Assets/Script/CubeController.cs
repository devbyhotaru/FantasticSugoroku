using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class CubeController : MLAPI.NetworkBehaviour
{
    void FixedUpdate()
    {
        if (!this.IsOwner) return;
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-10.0f, 0.0f, 0.0f);
        }
        // �E�Ɉړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(10.0f, 0.0f, 0.0f);
        }
        // ��Ɉړ�
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0.0f, 0.0f, 10.0f);
        }
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0.0f, 0.0f, -10.0f);
        }
    }
}