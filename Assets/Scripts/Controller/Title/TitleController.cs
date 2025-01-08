using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Controller.Title
{
    public class Controller : MonoBehaviour
    {
        [SerializeField] private Button exitButton;
        
        [Inject] private IPresenter _presenter;

        void Start()
        {
            exitButton.onClick.AddListener(_presenter.OnClickExit);
        }
    }
}