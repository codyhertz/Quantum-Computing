using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.Simulators.QCTraceSimulators;
using System.Diagnostics;
using Microsoft.Quantum.Simulation.QCTraceSimulatorRuntime;

namespace Quantum.DepthCounterProgram
{
    class Driver
    {
        static void Main(string[] args)
        {
            var config = new QCTraceSimulatorConfiguration();
            config.useDepthCounter = true;

            var sim = new QCTraceSimulator(config);
            var res = CCNOTDriver.Run(sim).Result;

            double tDepth = sim.GetMetric<Microsoft.Quantum.Primitive.CCNOT, CCNOTDriver>(DepthCounter.Metrics.Depth);
            double tDepthAll = sim.GetMetric<CCNOTDriver>(DepthCounter.Metrics.Depth);

            string csvSummary = sim.ToCSV()[MetricsCountersNames.depthCounter];
            System.Console.WriteLine(csvSummary);
            System.Console.WriteLine(tDepth);
            System.Console.WriteLine(tDepthAll);
            System.Console.ReadKey();
        }
    }
}