using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartRotationLocker : MonoBehaviour
{
    public Transform cartHandleTransform;

    void LateUpdate()
    {
        cartHandleTransform.rotation = Quaternion.Euler(90, cartHandleTransform.eulerAngles.y, 0);
        cartHandleTransform.localPosition = new Vector3(cartHandleTransform.localPosition.x, 1.186f, cartHandleTransform.localPosition.z);
    }
}
