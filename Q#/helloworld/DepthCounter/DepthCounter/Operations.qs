<<<<<<< HEAD
﻿namespace Quantum.DepthCounterProgram
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
=======
﻿namespace Quantum.DepthCounterProgram
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
>>>>>>> d2ef60db7ff9e132330bfc48bfc4b8a1f1d9d954
