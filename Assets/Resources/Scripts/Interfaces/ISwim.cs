namespace HenriqueGrecov.Bronziere
{
	public interface ISwim : IMovement
	{
		void Swim(float horizontal, float vertical, float depth, bool dive);
	}
}