namespace Quantum.DepthCounterProgram
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation CCNOTDriver() : Unit {
        body(...)
		{
			using(qubits = Qubit[3])
			{
				CCNOT(qubits[0], qubits[1], qubits[2]);
				T(qubits[0]);
			}
		}
    }
}
