using System;

namespace HenriqueGrecov.Bronziere
{
	public class AverageEnemy : ICharacter, IWalkBehaviour, ISwim, IDamageable
	{
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