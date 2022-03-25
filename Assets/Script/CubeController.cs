using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class CubeController : MLAPI.NetworkBehaviour
{
    void FixedUpdate()
    {
        if (!this.IsOwner) return;
        // ¶‚ÉˆÚ“®
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-10.0f, 0.0f, 0.0f);
        }
        // ‰E‚ÉˆÚ“®
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(10.0f, 0.0f, 0.0f);
        }
        // ã‚ÉˆÚ“®
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0.0f, 0.0f, 10.0f);
        }
        // ‰º‚ÉˆÚ“®
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0.0f, 0.0f, -10.0f);
        }
    }
}