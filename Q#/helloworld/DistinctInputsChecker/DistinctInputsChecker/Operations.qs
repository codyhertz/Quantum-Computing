namespace Quantum.DistinctInputsChecker
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation DoBoth( q1 : Qubit, q2 : Qubit, op1 : (Qubit => Unit), op2 : (Qubit => Unit)) : Unit {
		body (...) {
			op1(q1);
			op2(q2);
		}
	}

	operation DisctinctQubitCaptured2Test () : Unit {
		body (...) {
			using( q = Qubit[3] ) {
				let op1 = CNOT(_, q[1]);
				let op2 = CNOT(q[1], _);
				DoBoth(q[0], q[2], op1, op2);
			}
		}
	}
}
