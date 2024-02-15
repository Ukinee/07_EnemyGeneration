using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _path;
    private Animator _animator;
    private readonly int _walkAnimation = Animator.StringToHash("WalkBool");

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool(_walkAnimation, true);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _path.position, _speed * Time.deltaTime);

        transform.LookAt(_path.position);
    }

    public void Init(Transform target)
    {
        _path = target;
    }
}
