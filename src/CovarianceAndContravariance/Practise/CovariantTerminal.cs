using CovarianceAndContravariance.Theory;

namespace CovarianceAndContravariance.Practise
{
    internal class CovariantTerminal<T> : ICovariantTerminal<T> where T: User, new()
    {
        public T Check(User user)
        {
            return default(T);
        }

        public void Pay(decimal amount, User user)
        {
            return;
        }
    }
}
