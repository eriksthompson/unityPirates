using UnityEngine;
using UnityEngine.InputSystem;


//Erik Thompson
    public class MovementControl : MonoBehaviour
    {
        [SerializeField] public GameObject playerToMove;
        [SerializeField] private float speed = 5f;
        private InputAction moveAction;
        public void Initialize(InputAction moveAction)
        {
            this.moveAction = moveAction;
            this.moveAction.Enable();
        }
        private void FixedUpdate()
        {
            Vector2 v = moveAction.ReadValue<Vector2>();
            //Debug.Log(v);
            // Move according to (x, y)
            if (v.y > 0)
            {
                playerToMove.transform.Translate(0, 0, speed);
            }
            if (v.y < 0)
            {
                playerToMove.transform.Translate(0, 0, -speed);
            }
            if (v.x > 0)
            {
                playerToMove.transform.Rotate(0f, 1f, 0f);
            }
            if (v.x < 0)
            {
            playerToMove.transform.Rotate(0f, -1f, 0f);
            }
        }
    }
