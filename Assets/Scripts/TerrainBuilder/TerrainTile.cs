using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class TerrainTile : MonoBehaviour
{
    [SerializeField]
    TerrainType terrainType;


    public void SetType(TerrainType type)
    {
        terrainType = type;
        if (type != null && type.sprite != null)
        {
            GetComponent<SpriteRenderer>().sprite = type.sprite;
        }

    }


}
