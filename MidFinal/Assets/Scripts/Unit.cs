using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnitSelectorManager.Instance.allUnitsList.Add(gameObject);
    }

    private void OnDestroy()
    {
        UnitSelectorManager.Instance.allUnitsList.Remove(gameObject);
    }
}
