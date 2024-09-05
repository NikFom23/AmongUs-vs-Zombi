using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _points;

    private int currentPointIndex = 0;
    private Animator _animator;
    private static readonly int isRunning = Animator.StringToHash("Run");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_points.Length > 0)
        {
            // ����������� ������� � ������� ����� � �������������� MoveTowards
            MoveTowardsPoint(_points[currentPointIndex]);

            // ���� ������ ���������� ������ � ������� �����
            if (Vector3.Distance(transform.position, _points[currentPointIndex].position) < 0.05f)
            {
                // ������������� ������ ����� � ������� �����
                transform.position = _points[currentPointIndex].position;

                // ������� � ��������� �����
                currentPointIndex = (currentPointIndex + 1) % _points.Length;

                // ��������� ��������
                _animator.SetTrigger(isRunning);
            }
        }
    }

    private void MoveTowardsPoint(Transform targetPoint)
    {
        // ���������� MoveTowards ��� ����� ������� ��������
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, _speed * Time.deltaTime);
    }

    // ����� ��� ��������� ���������� ������� ��� ������������ � ������
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _points[currentPointIndex])
        {
            // ��������� ���������� ������� �� ������� ��������� �����
            transform.rotation = _points[currentPointIndex].rotation;
        }
    }
}