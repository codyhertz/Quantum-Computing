#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Bell\",\"Name\":\"Set\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/Bell/Bell/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Bell\",\"Name\":\"Set\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/Bell/Bell/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Bell\",\"Name\":\"BellTest\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/Bell/Bell/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Bell\",\"Name\":\"BellTest\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/Bell/Bell/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Bell
{
    public class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Quantum.Bell.Set";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in) =>
        {
            var (desired,qubit1) = __in;
#line 7 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
            var current = M.Apply(qubit1);
#line 9 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
            if ((desired != current))
            {
#line 11 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubit1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit qubit1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, qubit1));
        }
    }

    public class BellTest : Operation<(Int64,Result), (Int64,Int64,Int64)>, ICallable
    {
        public BellTest(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Result)>, IApplyData
        {
            public In((Int64,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "BellTest";
        String ICallable.FullName => "Quantum.Bell.BellTest";
        protected Allocate Allocate
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

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Int64,Result), (Int64,Int64,Int64)> Body => (__in) =>
        {
            var (count,initial) = __in;
#line 17 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
            var numOnes = 0L;
#line 18 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
            var agree = 0L;
#line hidden
            {
#line 19 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                var qubits = Allocate.Apply(2L);
#line 21 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                foreach (var test in new Range(1L, count))
#line hidden
                {
#line 23 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                    Set.Apply((initial, qubits[0L]));
#line 24 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                    Set.Apply((Result.Zero, qubits[1L]));
#line 26 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 27 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 28 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                    var res = M.Apply(qubits[0L]);
#line 30 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                    if ((M.Apply(qubits[1L]) == res))
                    {
#line 32 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                        agree = (agree + 1L);
                    }

#line 36 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                    if ((res == Result.One))
                    {
#line 38 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                        numOnes = (numOnes + 1L);
                    }
                }

#line 41 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                Set.Apply((Result.Zero, qubits[0L]));
#line 42 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
                Set.Apply((Result.Zero, qubits[1L]));
#line hidden
                Release.Apply(qubits);
            }

#line 45 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\Bell\\Bell\\Operations.qs"
            return ((count - numOnes), numOnes, agree);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Int64,Result) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Result initial)
        {
            return __m__.Run<BellTest, (Int64,Result), (Int64,Int64,Int64)>((count, initial));
        }
    }
}