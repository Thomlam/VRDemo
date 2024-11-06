using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    public TextMeshProUGUI registerText;

    public void CheckForObject()
    {
        Debug.Log("activate called");
        
        RaycastHit hit;
        bool hasHit = Physics.Raycast(transform.position, Vector3.forward, out hit, 1);

        if(hasHit) registerText.text = hit.collider.gameObject.name;
    }
}
