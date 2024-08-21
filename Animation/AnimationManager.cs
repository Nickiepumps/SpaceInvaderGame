using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private GameObject entity;
    public void DeleteEntity()
    {
        Destroy(entity);
    }
}
