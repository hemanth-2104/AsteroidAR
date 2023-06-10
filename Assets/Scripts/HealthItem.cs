using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthItem : MonoBehaviour
{
    [SerializeField] private string _tagToCompare = "Player";
    [SerializeField] private int _healingPower = 10;
    [SerializeField] private UnityEvent OnHeal;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag(_tagToCompare))
        {

        }
        if (other.TryGetComponent(out Health health)) 
        {

        }
        health.GainHealth(_healingPower);
        OnHeal?.Invoke();
    }
}
