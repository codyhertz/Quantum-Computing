#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"Teleportation\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/Simulator/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"source\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"Teleportation\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/Simulator/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QSharpApplication1
{
    public class Teleportation : Operation<(Qubit,Qubit), QVoid>, ICallable
    {
        public Teleportation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Teleportation";
        String ICallable.FullName => "Quantum.QSharpApplication1.Teleportation";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)> AssertProb
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (source,target) = __in;
#line hidden
            {
#line 9 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                var ancillaRegister = Allocate.Apply(1L);
#line 11 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                var ancilla = ancillaRegister[0L];
#line 13 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(ancilla);
#line 14 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((ancilla, target));
#line 16 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((source, ancilla));
#line 17 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(source);
#line 19 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                AssertProb.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {source}, Result.Zero, 0.5D, "Outcomes must be equally likely", 1E-05D));
#line 20 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                AssertProb.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {ancilla}, Result.Zero, 0.5D, "Outcomes must be equally likely", 1E-05D));
#line 22 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                if ((M.Apply(source) == Result.One))
                {
#line 24 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                    MicrosoftQuantumPrimitiveZ.Apply(target);
#line 25 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(source);
                }

#line 27 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                if ((M.Apply(ancilla) == Result.One))
                {
#line 29 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(target);
#line 30 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Simulator\\QSharpApplication1\\Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(ancilla);
                }

#line hidden
                Release.Apply(ancillaRegister);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit source, Qubit target)
        {
            return __m__.Run<Teleportation, (Qubit,Qubit), QVoid>((source, target));
        }
    }
}