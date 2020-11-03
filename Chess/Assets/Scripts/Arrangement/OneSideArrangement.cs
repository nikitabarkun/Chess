using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Arrangement
{
    [CreateAssetMenu(fileName = "One Side Arrangement", menuName = "Chess/Arrangement/One Side Arrangement", order = 0)]
    public class OneSideArrangement : ScriptableObject
    {
        [SerializeField] private FigureArrangementInfo[] pawns;
        [SerializeField] private FigureArrangementInfo[] knights;
        [SerializeField] private FigureArrangementInfo[] rooks;
        [SerializeField] private FigureArrangementInfo[] bishops;
        [SerializeField] private FigureArrangementInfo[] queens;
        [SerializeField] private FigureArrangementInfo king;

        [SerializeField] private Color _color;
        
        private bool _isValid = false;

        public FigureArrangementInfo[] Pawns => pawns;
        public FigureArrangementInfo[] Knights => knights;
        public FigureArrangementInfo[] Rooks => rooks;
        public FigureArrangementInfo[] Bishops => bishops;
        public FigureArrangementInfo[] Queens => queens;
        public FigureArrangementInfo King => king;

        public Color Color => _color;
        public bool IsValid => _isValid;

        private void OnEnable()
        {
            IsValidArrangement();

            foreach (var figure in GetAllFigures())
            {
                figure.FigureData.SetColor(_color);
            }
        }
        
        public List<FigureArrangementInfo> GetAllFigures()
        {
            var figures = new List<FigureArrangementInfo>();
            
            figures.AddRange(pawns);
            figures.AddRange(knights);
            figures.AddRange(rooks);
            figures.AddRange(bishops);
            figures.AddRange(queens);
            figures.Add(king);

            return figures;
        }
        
        private void IsValidArrangement()
        {
            var occupyMap = GetOccupyMap();
            
            foreach (var placement in occupyMap)
            {
                if (placement > 1)
                {
                    _isValid = false;
                    return;
                }
            }
        }

        private int[,] GetOccupyMap()
        {
            var occupyMap = new int[8, 8];

            foreach (var pawn in pawns)
            {
                occupyMap = CheckFigureArrangement(pawn, occupyMap);
            }
            foreach (var knight in knights)
            {
                occupyMap = CheckFigureArrangement(knight, occupyMap);
            }
            foreach (var rook in rooks)
            {
                occupyMap = CheckFigureArrangement(rook, occupyMap);
            }
            foreach (var bishop in bishops)
            {
                occupyMap = CheckFigureArrangement(bishop, occupyMap);
            }
            foreach (var queen in queens)
            {
                occupyMap = CheckFigureArrangement(queen, occupyMap);
            }
            occupyMap = CheckFigureArrangement(king, occupyMap);
            
            return occupyMap;
        }
        
        private int[,] CheckFigureArrangement(FigureArrangementInfo figure, int[,] occupyMap)
        {
            occupyMap[figure.Position.x, figure.Position.y]++;
            return occupyMap;
        }
    }
}