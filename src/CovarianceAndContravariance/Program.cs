using CovarianceAndContravariance.Practise;
using CovarianceAndContravariance.Theory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CovarianceAndContravariance
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Covariance Part 1

            //object[] array = new string[] { "s", "t" };
            //Console.WriteLine(array[0].GetType());


            //// This is Covariance => When you can raise child class \
            //// as a Parent class
            //// All arrays are covariant
            //array[0].GetType().Print(); // System.String
            //// Hower it has only for methods of object not string


            #endregion

            #region  Covariance Part 2
            //// Covariance isn't that cool
            //object[] array = new User[3];
            //array[0] = new User();
            //// Here Exception will be thrown
            //array[1] = new string("Execption is going to raise"); 
            #endregion

            #region Covariance Part 3
            ////// Worker inherits User
            ////// Worker:User

            //// This Works
            ////ICovariantTerminal<out T>
            //ICovariantTerminal<User> terminal = new CovariantTerminal<Worker>();

            //// BUT
            //// Thid doesn't work
            //CovariantTerminal<User> terminal2 = new CovariantTerminal<Worker>();


            //// Invariant one is not working
            //// InvariantTerminal < T>
            //IInvariantTerminal<User> iTerminal = new InvariantTerminal<Worker>();
            //IInvariantTerminal<User> iTerminal2 = new InvariantTerminal<User>();


            #endregion

            #region Contrvariance Part 4

            //// Contrvariance
            //// Worker inherits User / Worker:User

            //IContrvariantTerminal<Worker> terminall = new ContrvariantTerminal<User>();

            //// Here compiler is yelling
            //IContrvariantTerminal<User> terminal22 = new ContrvariantTerminal<Worker>();


            #endregion


            INotifyPropertyChanged

            Console.ReadLine();
        }
    }
}
