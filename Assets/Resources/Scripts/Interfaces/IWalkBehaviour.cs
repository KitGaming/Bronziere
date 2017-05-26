namespace HenriqueGrecov.Bronziere
{
	public interface IWalkBehaviour : IMovement
	{
		void Walk(float horizontal, float vertical, bool crouching);
	}
}