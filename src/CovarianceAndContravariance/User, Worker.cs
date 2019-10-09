namespace CovarianceAndContravariance
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Worker : User
    {
        public string Salary { get; set; }
    }
}
