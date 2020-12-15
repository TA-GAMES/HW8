using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * This component allows the player to move by clicking the arrow keys,
 * but only if the new position is on an allowed tile.
 */
public class KeyboardMoverByTile: KeyboardMover {
    [SerializeField] Tilemap tilemap = null;
    [SerializeField] AllowedTiles allowedTiles = null;
    [SerializeField] TileBase tileSweepTo = null;
    [SerializeField] TileBase tileSweepFrom = null;


    private TileBase TileOnPosition(Vector3 worldPosition) {
        Vector3Int cellPosition = tilemap.WorldToCell(worldPosition);
        return tilemap.GetTile(cellPosition);
    }

    void Update()  {
        Vector3 newPosition = NewPosition();
        TileBase tileOnNewPosition = TileOnPosition(newPosition);

        if (allowedTiles.Contain(tileOnNewPosition)) {
            transform.position = newPosition;
        } 
        else if (!allowedTiles.Contain(tileOnNewPosition) && tileOnNewPosition.Equals(tileSweepFrom) && Input.GetKey(KeyCode.Space))
        {
            tilemap.SetTile(tilemap.WorldToCell(newPosition), tileSweepTo);
        }
        else {
            Debug.Log("You cannot walk on " + tileOnNewPosition + "!");
        }
    }
}
