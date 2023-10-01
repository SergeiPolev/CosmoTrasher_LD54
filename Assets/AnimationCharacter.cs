using UnityEngine;
using Random = UnityEngine.Random;

public class AnimationCharacter : MonoBehaviour
{
	[SerializeField] private Rigidbody2D _rb;
	[SerializeField] private Transform _flameTr;
	[SerializeField] private Transform _gunRoot;
	[SerializeField] private Vector2 _flameRotRange;
	[SerializeField] private float _velocityDivider = 1f;

	private float currentAngleTarget;
	private float currentAngle;

	private void Start()
	{
		currentAngle = currentAngleTarget = Random.Range(_flameRotRange.x, _flameRotRange.y);
	}

	private void Update()
	{
		Vector2 velocity = _rb.velocity;
		currentAngleTarget = Random.Range(_flameRotRange.x, _flameRotRange.y);
		var lerpSpeed = velocity.magnitude / _velocityDivider;

		currentAngle = Mathf.Lerp(currentAngle, currentAngleTarget, Time.deltaTime * lerpSpeed);

		_flameTr.localRotation = Quaternion.Euler(0, 0, currentAngle);

		var scale = transform.localScale;

		scale.x = velocity.x > 0 ? 1 : -1;
		transform.localScale = scale;
		_gunRoot.localScale = scale;
	}
}