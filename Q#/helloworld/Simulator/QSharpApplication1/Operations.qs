<<<<<<< HEAD
﻿namespace Quantum.QSharpApplication1
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Teleportation (source: Qubit, target: Qubit) : Unit {
        body(...)
		{
			using(ancillaRegister = Qubit[1])
			{
				let ancilla = ancillaRegister[0];

				H(ancilla);
				CNOT(ancilla, target);

				CNOT(source, ancilla);
				H(source);

				AssertProb([PauliZ], [source], Zero, 0.5, "Outcomes must be equally likely", 1e-5);
				AssertProb([PauliZ], [ancilla], Zero, 0.5, "Outcomes must be equally likely", 1e-5);

				if(M(source) == One)
				{
					Z(target);
					X(source);
				}
				if(M(ancilla) == One)
				{
					X(target);
					X(ancilla);
				}
			}
		}
    }
}
=======
﻿namespace Quantum.QSharpApplication1
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Teleportation (source: Qubit, target: Qubit) : Unit {
        body(...)
		{
			using(ancillaRegister = Qubit[1])
			{
				let ancilla = ancillaRegister[0];

				H(ancilla);
				CNOT(ancilla, target);

				CNOT(source, ancilla);
				H(source);

				AssertProb([PauliZ], [source], Zero, 0.5, "Outcomes must be equally likely", 1e-5);
				AssertProb([PauliZ], [ancilla], Zero, 0.5, "Outcomes must be equally likely", 1e-5);

				if(M(source) == One)
				{
					Z(target);
					X(source);
				}
				if(M(ancilla) == One)
				{
					X(target);
					X(ancilla);
				}
			}
		}
    }
}
>>>>>>> d2ef60db7ff9e132330bfc48bfc4b8a1f1d9d954
