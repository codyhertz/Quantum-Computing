<<<<<<< HEAD
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DistinctInputsChecker\",\"Name\":\"DoBoth\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DistinctInputsChecker/DistinctInputsChecker/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q2\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DistinctInputsChecker\",\"Name\":\"DoBoth\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DistinctInputsChecker/DistinctInputsChecker/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DistinctInputsChecker\",\"Name\":\"DisctinctQubitCaptured2Test\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DistinctInputsChecker/DistinctInputsChecker/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DistinctInputsChecker\",\"Name\":\"DisctinctQubitCaptured2Test\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DistinctInputsChecker/DistinctInputsChecker/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.DistinctInputsChecker
{
    public class DoBoth : Operation<(Qubit,Qubit,ICallable,ICallable), QVoid>, ICallable
    {
        public DoBoth(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,ICallable,ICallable)>, IApplyData
        {
            public In((Qubit,Qubit,ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "DoBoth";
        String ICallable.FullName => "Quantum.DistinctInputsChecker.DoBoth";
        public override Func<(Qubit,Qubit,ICallable,ICallable), QVoid> Body => (__in) =>
        {
            var (q1,q2,op1,op2) = __in;
#line 8 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
            op1.Apply(q1);
#line 9 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
            op2.Apply(q2);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Qubit,Qubit,ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q1, Qubit q2, ICallable op1, ICallable op2)
        {
            return __m__.Run<DoBoth, (Qubit,Qubit,ICallable,ICallable), QVoid>((q1, q2, op1, op2));
        }
    }

    public class DisctinctQubitCaptured2Test : Operation<QVoid, QVoid>, ICallable
    {
        public DisctinctQubitCaptured2Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DisctinctQubitCaptured2Test";
        String ICallable.FullName => "Quantum.DistinctInputsChecker.DisctinctQubitCaptured2Test";
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

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit,ICallable,ICallable), QVoid> DoBoth
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 15 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
                var q = Allocate.Apply(3L);
#line 16 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
                var op1 = MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, q[1L])));
#line 17 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
                var op2 = MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg2) => (q[1L], _arg2)));
#line 18 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
                DoBoth.Apply((q[0L], q[2L], op1, op2));
#line hidden
                Release.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.DoBoth = this.Factory.Get<ICallable<(Qubit,Qubit,ICallable,ICallable), QVoid>>(typeof(DoBoth));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<DisctinctQubitCaptured2Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
=======
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DistinctInputsChecker\",\"Name\":\"DoBoth\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DistinctInputsChecker/DistinctInputsChecker/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q2\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DistinctInputsChecker\",\"Name\":\"DoBoth\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DistinctInputsChecker/DistinctInputsChecker/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DistinctInputsChecker\",\"Name\":\"DisctinctQubitCaptured2Test\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DistinctInputsChecker/DistinctInputsChecker/Operations.qs\",\"Position\":{\"Item1\":12,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DistinctInputsChecker\",\"Name\":\"DisctinctQubitCaptured2Test\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DistinctInputsChecker/DistinctInputsChecker/Operations.qs\",\"Position\":{\"Item1\":13,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.DistinctInputsChecker
{
    public class DoBoth : Operation<(Qubit,Qubit,ICallable,ICallable), QVoid>, ICallable
    {
        public DoBoth(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,ICallable,ICallable)>, IApplyData
        {
            public In((Qubit,Qubit,ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "DoBoth";
        String ICallable.FullName => "Quantum.DistinctInputsChecker.DoBoth";
        public override Func<(Qubit,Qubit,ICallable,ICallable), QVoid> Body => (__in) =>
        {
            var (q1,q2,op1,op2) = __in;
#line 8 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
            op1.Apply(q1);
#line 9 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
            op2.Apply(q2);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Qubit,Qubit,ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q1, Qubit q2, ICallable op1, ICallable op2)
        {
            return __m__.Run<DoBoth, (Qubit,Qubit,ICallable,ICallable), QVoid>((q1, q2, op1, op2));
        }
    }

    public class DisctinctQubitCaptured2Test : Operation<QVoid, QVoid>, ICallable
    {
        public DisctinctQubitCaptured2Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DisctinctQubitCaptured2Test";
        String ICallable.FullName => "Quantum.DistinctInputsChecker.DisctinctQubitCaptured2Test";
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

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit,ICallable,ICallable), QVoid> DoBoth
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 15 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
                var q = Allocate.Apply(3L);
#line 16 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
                var op1 = MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, q[1L])));
#line 17 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
                var op2 = MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg2) => (q[1L], _arg2)));
#line 18 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DistinctInputsChecker\\DistinctInputsChecker\\Operations.qs"
                DoBoth.Apply((q[0L], q[2L], op1, op2));
#line hidden
                Release.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.DoBoth = this.Factory.Get<ICallable<(Qubit,Qubit,ICallable,ICallable), QVoid>>(typeof(DoBoth));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<DisctinctQubitCaptured2Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
>>>>>>> d2ef60db7ff9e132330bfc48bfc4b8a1f1d9d954
}