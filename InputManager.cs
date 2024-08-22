/*using ThompsonErik.Lab1;
using ThompsonErik.input;*/
using UnityEngine;

//Erik Thompson
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private MovementControl movementController;
        [SerializeField] private PlayerRespawner playerRespawner;
        [SerializeField] private CannonFire cannonFire;
        private MainPlayerControl inputScheme;
        private ResetHandler resetHandler;
        private FireHandler fireHandler;
        private void Awake()
        {
            inputScheme = new MainPlayerControl();
            movementController.Initialize(inputScheme.Player.Move);
            resetHandler = new ResetHandler(inputScheme.Player.Reset, playerRespawner);
            fireHandler = new FireHandler(inputScheme.Player.Fire, cannonFire);
            
        }
        private void OnEnable()
        {
            var _ = new QuitHandler(inputScheme.Player.Quit);
        }
    }