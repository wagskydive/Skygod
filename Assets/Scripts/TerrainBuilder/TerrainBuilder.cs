using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TerrainBuilder : MonoBehaviour
{
    TerrainType[,] map;

    [SerializeField]
    GameObject tilePrefab;

    float tileSize;


    [SerializeField]
    TerrainType[] allTerrainTypes;

    [SerializeField]
    TerrainType emptyTerrainType;

    
}

