using System;
using Scripts.Arrangement;
using UnityEngine;

namespace Scripts
{
    [CreateAssetMenu(fileName = "Board", menuName = "Chess/Board", order = 0)]
    public class BoardData : ScriptableObject
    {
        [SerializeField] private FullArrangement arrangement;
        
        private FigureArrangementInfo[,] _squares = new FigureArrangementInfo[8, 8];

        public FullArrangement Arrangement => arrangement;
        
        public FigureArrangementInfo[,] Squares => _squares;
    }
}