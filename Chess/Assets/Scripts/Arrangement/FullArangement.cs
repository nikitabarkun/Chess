using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Arrangement
{
    [CreateAssetMenu(fileName = "Full Arrangement", menuName = "Chess/Arrangement/Full Arrangement", order = 0)]
    public class FullArrangement : ScriptableObject
    {
        [SerializeField] private OneSideArrangement whiteSideArrangement;
        [SerializeField] private OneSideArrangement blackSideArrangement;

        public OneSideArrangement WhiteSideArrangement => whiteSideArrangement;
        public OneSideArrangement BlackSideArrangement => blackSideArrangement;

        public List<FigureArrangementInfo> GetAllFigures()
        {
            var figures = new List<FigureArrangementInfo>();
            
            figures.AddRange(whiteSideArrangement.GetAllFigures());
            figures.AddRange(blackSideArrangement.GetAllFigures());

            return figures;
        }
    }
}