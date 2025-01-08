using UnityEngine;

namespace UseCase.Title
{
    public interface ITitleUseCase
    {
        void Exit();
    }

    public class TitleUseCase : ITitleUseCase
    {
        public TitleUseCase()
        {}

        public void Exit()
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else   
                UnityEngine.Application.Quit();
            #endif
        }
    }
}