<<<<<<< HEAD
﻿using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.Simulators.QCTraceSimulators;

namespace Quantum.QSharpApplication1
{
    class Driver
    {
        static void Main(string[] args)
        {
            QCTraceSimulator sim = new QCTraceSimulator();
            var res = Operations.Run().Result;
            System.Console.WriteLine("Press blahblah");
            System.Console.ReadKey();
        }
    }
=======
﻿using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.Simulators.QCTraceSimulators;

namespace Quantum.QSharpApplication1
{
    class Driver
    {
        static void Main(string[] args)
        {
            QCTraceSimulator sim = new QCTraceSimulator();
            var res = Operations.Run().Result;
            System.Console.WriteLine("Press blahblah");
            System.Console.ReadKey();
        }
    }
>>>>>>> d2ef60db7ff9e132330bfc48bfc4b8a1f1d9d954
}