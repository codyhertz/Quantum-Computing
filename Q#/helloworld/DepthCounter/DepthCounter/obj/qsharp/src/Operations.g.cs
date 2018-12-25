<<<<<<< HEAD
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DepthCounterProgram\",\"Name\":\"CCNOTDriver\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DepthCounter/DepthCounter/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DepthCounterProgram\",\"Name\":\"CCNOTDriver\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DepthCounter/DepthCounter/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.DepthCounterProgram
{
    public class CCNOTDriver : Operation<QVoid, QVoid>, ICallable
    {
        public CCNOTDriver(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CCNOTDriver";
        String ICallable.FullName => "Quantum.DepthCounterProgram.CCNOTDriver";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveT
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 9 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DepthCounter\\DepthCounter\\Operations.qs"
                var qubits = Allocate.Apply(3L);
#line 11 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DepthCounter\\DepthCounter\\Operations.qs"
                MicrosoftQuantumPrimitiveCCNOT.Apply((qubits[0L], qubits[1L], qubits[2L]));
#line 12 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DepthCounter\\DepthCounter\\Operations.qs"
                MicrosoftQuantumPrimitiveT.Apply(qubits[0L]);
#line hidden
                Release.Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.T));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<CCNOTDriver, QVoid, QVoid>(QVoid.Instance);
        }
    }
=======
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DepthCounterProgram\",\"Name\":\"CCNOTDriver\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DepthCounter/DepthCounter/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DepthCounterProgram\",\"Name\":\"CCNOTDriver\"},\"SourceFile\":\"C:/Users/codyh/OneDrive/other%20one%20drive/OneDrive/Desktop/programs/quantum/mine/DepthCounter/DepthCounter/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.DepthCounterProgram
{
    public class CCNOTDriver : Operation<QVoid, QVoid>, ICallable
    {
        public CCNOTDriver(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CCNOTDriver";
        String ICallable.FullName => "Quantum.DepthCounterProgram.CCNOTDriver";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveT
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 9 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DepthCounter\\DepthCounter\\Operations.qs"
                var qubits = Allocate.Apply(3L);
#line 11 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DepthCounter\\DepthCounter\\Operations.qs"
                MicrosoftQuantumPrimitiveCCNOT.Apply((qubits[0L], qubits[1L], qubits[2L]));
#line 12 "C:\\Users\\codyh\\OneDrive\\other one drive\\OneDrive\\Desktop\\programs\\quantum\\mine\\DepthCounter\\DepthCounter\\Operations.qs"
                MicrosoftQuantumPrimitiveT.Apply(qubits[0L]);
#line hidden
                Release.Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.T));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<CCNOTDriver, QVoid, QVoid>(QVoid.Instance);
        }
    }
>>>>>>> d2ef60db7ff9e132330bfc48bfc4b8a1f1d9d954
}