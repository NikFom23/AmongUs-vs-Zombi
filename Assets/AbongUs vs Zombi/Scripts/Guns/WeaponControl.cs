using System.Collections;
using UnityEngine;

namespace Guns {

    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(Rigidbody2D))]

    public class WeaponControl : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private float _bulletForce;
        [SerializeField] private float _bulletTime;
        [SerializeField] private SpriteRenderer _sprite;

        private Vector2 _mousePosition;
        private Rigidbody2D _rigidBody;
        
        private float _nextShoot;
        private GameObject _playerClone;
        private Transform _player;
        public GameSession _gameSession;


        private void Awake()
        {
            
            _rigidBody = GetComponent<Rigidbody2D>();
            _playerClone = GameObject.Find("Red(Clone)");
            _player = _playerClone.transform;
        }

        

        private void Update()
        {
            GunPosition();
            
        }

        private void FixedUpdate()
        {
            LookAtMouse();
            SpriteReflect();
        }

        private void GunPosition()
        {
            transform.position = new Vector3(_player.position.x , _player.position.y, transform.position.z);
        }


        private void LookAtMouse()
        {
            _mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 lookDir = _mousePosition - _rigidBody.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
            _rigidBody.rotation = angle;
            
        }

        private void SpriteReflect()
        {
            _sprite = _gameSession.Data._gunObj.GetComponent<SpriteRenderer>();

            if (_rigidBody.rotation > 90f || _rigidBody.rotation < -90f)
            {
                _sprite.flipY = true;
                _playerClone.GetComponent<SpriteRenderer>().flipX = true;
            }
            else if (_rigidBody.rotation < 90f || _rigidBody.rotation > -90f)
            {
                _sprite.flipY = false;
                _playerClone.GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }
}