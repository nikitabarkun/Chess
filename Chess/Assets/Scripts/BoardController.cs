using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Scripts
{
    public class BoardController : MonoBehaviour
    {
        [SerializeField] private BoardData boardData;

        public void Start()
        {
            if (boardData.Arrangement.WhiteSideArrangement.IsValid &&
                boardData.Arrangement.BlackSideArrangement.IsValid)
            {
                var figures = boardData.Arrangement.GetAllFigures();

                for (int i = 0; i < figures.Count; i++)
                {
                    figures[i].Init();
                }
            }
        }
    }
}
