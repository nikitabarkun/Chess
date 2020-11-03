using System.Security.Cryptography;
using UnityEngine;

namespace Scripts
{
    [CreateAssetMenu(fileName = "Figure", menuName = "Chess/Figure", order = 0)]
    public class FigureData : ScriptableObject
    {
        [SerializeField] private Mesh mesh;

        [SerializeField] private MovePatterns movePattern;
        
        private Color _color;

        public MovePatterns MovePattern => movePattern;
        public Mesh Mesh => mesh;

        public void SetColor(Color color)
        {
            _color = color;
        }
    }
}