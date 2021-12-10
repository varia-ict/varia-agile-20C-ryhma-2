// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä
// Tämä Ei Ole Käytössä

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFacing : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0.0f, 180f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0.0f, -180f, 0.0f);
        }
    }
}
