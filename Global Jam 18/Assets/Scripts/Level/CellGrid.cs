using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellGrid : MonoBehaviour {

    public int x = 5;
    public int z = 5;

    [SerializeField]
    public Cell[] cells;

    private void Awake()
    {

    }
}
