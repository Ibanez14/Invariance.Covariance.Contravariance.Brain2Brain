using System;
using System.Collections.Generic;
using System.Text;

namespace CovarianceAndContravariance.Theory
{
    /// <summary>
    /// INVARIANCE. Allows you to take T as Parameter and return T as type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IInvariantTerminal<T>
    {
        void Pay(decimal amount, T user);
        void Check(T user);
        T returnType();
    }


    /// <summary>
    /// COVARIANCE
    /// Allow you only to return T in methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICovariantTerminal<out T>
    {
        // Here T wont work, compiler is yelling
        //void Pay(decimal, T user);
        void Pay(decimal amount, User user);
        T Check(User user);
    }


    /// <summary>
    /// CONTRVARIANT Allow only to take parameter of T and nothing else
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IContrvariantTerminal<in T>
    {
        void Pay(decimal amoun, T user);
        // This doesnt work, Compiler is yelling
        //T Check();
    }




}
