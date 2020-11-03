using System.Collections;
using System.Collections.Generic;
using Scripts;
using UnityEngine;

public class Figure : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    
    private FigureData _figureData;
    private Vector2Int _position;

    public GameObject Init(FigureData figureData)
    {
        _figureData = figureData;
        
        GetComponent<MeshFilter>().mesh = figureData.Mesh;
        
        return Instantiate(prefab, new Vector3(_position.x, 0, _position.y), Quaternion.identity);
    }
}
