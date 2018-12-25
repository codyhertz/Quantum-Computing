namespace Quantum.Bell
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Set (desired: Result, qubit1: Qubit) : Unit {
        let current = M(qubit1);

		if(desired != current)
		{
			X(qubit1);
		}
    }

	operation BellTest (count: Int, initial: Result) : (Int, Int, Int)
	{
		mutable numOnes = 0;
		mutable agree = 0;
		using(qubits = Qubit[2])
		{
			for(test in 1..count)
			{
				Set(initial, qubits[0]);
				Set(Zero, qubits[1]);

				H(qubits[0]);
				CNOT(qubits[0], qubits[1]);
				let res = M(qubits[0]);

				if(M(qubits[1]) == res)
				{
					set agree = agree + 1;
				}

				// count number of one outputs
				if(res == One)
				{
					set numOnes = numOnes + 1;
				}
			}
			Set(Zero, qubits[0]);
			Set(Zero, qubits[1]);
		}
		// return number of times we saw |0> and |1> and number of times both qubits had the same output
		return(count-numOnes, numOnes, agree);
	}
}
