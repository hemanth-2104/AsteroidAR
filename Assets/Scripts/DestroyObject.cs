using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private float _destroyDelay = 0.1f;
    [SerializeField] private UnityEvent OnDestroy;
    
    public void DestroyWithDelay()
    {
        // Debug.Log($"{gameObject.name} destroyed");
        OnDestroy?.Invoke();
        Destroy(gameObject, _destroyDelay);
    }
}
