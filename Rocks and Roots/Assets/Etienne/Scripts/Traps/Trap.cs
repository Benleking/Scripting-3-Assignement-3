using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trap : MonoBehaviour
{
    public abstract void OnPlayerEnter(PlayerScript player);
}
