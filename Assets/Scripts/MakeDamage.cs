using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Makes damage to a GameObject containing a Health script
public class MakeDamage : MonoBehaviour
{
    [SerializeField] private int _damagePower = 10;
    [SerializeField] private string _tagToCompare = "Player";
    [SerializeField] private UnityEvent OnTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_tagToCompare))
        {
            if (other.TryGetComponent(out Health health))
            {
                if (health.enabled)
                {
                    health.ReceiveDamage(_damagePower);
                    OnTrigger?.Invoke();    
                }
            }
        }
    }
}