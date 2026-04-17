using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineController : MonoBehaviour
{

    [field: SerializeField] public bool IsActive { get; private set; } = false;
    [SerializeField] private ParticleSystem particleSystem;

    public void Set(bool state)
    {
        if (IsActive && state)
        {
            return;
        }
        IsActive = state;
        particleSystem.gameObject.SetActive(state);
    }
}
