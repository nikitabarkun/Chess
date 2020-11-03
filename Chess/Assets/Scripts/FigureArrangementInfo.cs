using System;
using UnityEngine;

namespace Scripts
{
    [Serializable]
    public class FigureArrangementInfo : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;

        [SerializeField] private FigureData figureData; 
        private Vector2Int _position;

        public FigureData FigureData => figureData;
        public Vector2Int Position => _position;
        
        public void Init()
        {
            GetComponent<MeshFilter>().mesh = figureData.Mesh;
        
            Instantiate(prefab, new Vector3(_position.x, 0, _position.y), Quaternion.identity);
            
            //no time left :c
        }
    }
}