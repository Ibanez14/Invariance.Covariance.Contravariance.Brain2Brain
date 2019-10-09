using CovarianceAndContravariance.Theory;

namespace CovarianceAndContravariance.Practise
{
    internal class InvariantTerminal<T> : IInvariantTerminal<T> where T : User, new()
    {
        public void Check(T user)
        {
        }

        public void Pay(decimal amount, T user)
        {
        }

        public T returnType()
        {
            return default(T);
        }
    }
}
