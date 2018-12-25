<<<<<<< HEAD
﻿using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Bell
{
    class Driver
    {
        static void Main(string[] args)
        {
            try
            {
                using(var qsim = new QuantumSimulator())
                {
                    // initial vals
                    Result[] initials = new Result[] { Result.Zero, Result.One };

                    foreach (Result initial in initials)
                    {
                        var res = BellTest.Run(qsim, 1000, initial).Result;
                        var (numZeros, numOnes, agree) = res;
                        System.Console.WriteLine($"Init:{initial,-4} 0s={numZeros,-4} 1s={numOnes,-4} agree={agree,-4}");
                    }
                }
            }
            catch(AggregateException e)
            {
                // to get the real error we need to iterate through the inner exceptions
                foreach(Exception inner in e.InnerExceptions)
                {
                    if(inner is ExecutionFailException failexception)
                    {
                        System.Console.WriteLine($" {failexception.Message}");
                    }
                }
            }

            System.Console.WriteLine("Press...");
            Console.ReadKey();
        }
    }
=======
﻿using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Bell
{
    class Driver
    {
        static void Main(string[] args)
        {
            try
            {
                using(var qsim = new QuantumSimulator())
                {
                    // initial vals
                    Result[] initials = new Result[] { Result.Zero, Result.One };

                    foreach (Result initial in initials)
                    {
                        var res = BellTest.Run(qsim, 1000, initial).Result;
                        var (numZeros, numOnes, agree) = res;
                        System.Console.WriteLine($"Init:{initial,-4} 0s={numZeros,-4} 1s={numOnes,-4} agree={agree,-4}");
                    }
                }
            }
            catch(AggregateException e)
            {
                // to get the real error we need to iterate through the inner exceptions
                foreach(Exception inner in e.InnerExceptions)
                {
                    if(inner is ExecutionFailException failexception)
                    {
                        System.Console.WriteLine($" {failexception.Message}");
                    }
                }
            }

            System.Console.WriteLine("Press...");
            Console.ReadKey();
        }
    }
>>>>>>> d2ef60db7ff9e132330bfc48bfc4b8a1f1d9d954
}