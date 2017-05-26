using System;

namespace HenriqueGrecov.Bronziere
{
	public class EliteEnemy : ICharacter, IWalkBehaviour, ISwim, IClimb, IDamageable
	{
		public void Climb(float horizontal, float vertical)
		{
			throw new NotImplementedException();
		}

		public void Swim(float horizontal, float vertical, bool dive)
		{
			throw new NotImplementedException();
		}

		public void Walk(float horizontal, float vertical, bool crouching)
		{
			throw new NotImplementedException();
		}
	}
}