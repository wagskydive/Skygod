using UnityEngine;

[CreateAssetMenu(fileName = "TileType", menuName = "Terrain/TileType")]
public class TerrainType : ScriptableObject
{
    [SerializeField]
    public Sprite sprite;

    [SerializeField]
    public TerrainType[] canNeighborRight;

    [SerializeField]
    public TerrainType[] canNeighborLeft;

    [SerializeField]
    public TerrainType[] canNeighborUp;

    [SerializeField]
    public TerrainType[] canNeighborDown;


    [SerializeField]
    int cost;


    public void Spawn()
    {

    }
}

