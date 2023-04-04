/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Interfaces;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Skyrim.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Skyrim.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class MagicEffectWerewolfArchetype :
        AMagicEffectArchetype,
        IEquatable<IMagicEffectWerewolfArchetypeGetter>,
        ILoquiObjectSetter<MagicEffectWerewolfArchetype>,
        IMagicEffectWerewolfArchetype
    {
        #region Association
        private readonly IFormLink<IRaceGetter> _Association = new FormLink<IRaceGetter>();
        public IFormLink<IRaceGetter> Association
        {
            get => _Association;
            set => _Association.SetTo(value);
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IFormLinkGetter<IRaceGetter> IMagicEffectWerewolfArchetypeGetter.Association => this.Association;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            MagicEffectWerewolfArchetypeMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IMagicEffectWerewolfArchetypeGetter rhs) return false;
            return ((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IMagicEffectWerewolfArchetypeGetter? obj)
        {
            return ((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            AMagicEffectArchetype.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
                this.Association = initialValue;
            }

            public Mask(
                TItem ActorValue,
                TItem Association)
            : base(ActorValue: ActorValue)
            {
                this.Association = Association;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Association;
            #endregion

            #region Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is Mask<TItem> rhs)) return false;
                return Equals(rhs);
            }

            public bool Equals(Mask<TItem>? rhs)
            {
                if (rhs == null) return false;
                if (!base.Equals(rhs)) return false;
                if (!object.Equals(this.Association, rhs.Association)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Association);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Association)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Association)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new MagicEffectWerewolfArchetype.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Association = eval(this.Association);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(MagicEffectWerewolfArchetype.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, MagicEffectWerewolfArchetype.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(MagicEffectWerewolfArchetype.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Association ?? true)
                    {
                        sb.AppendItem(Association, "Association");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            AMagicEffectArchetype.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Association;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                MagicEffectWerewolfArchetype_FieldIndex enu = (MagicEffectWerewolfArchetype_FieldIndex)index;
                switch (enu)
                {
                    case MagicEffectWerewolfArchetype_FieldIndex.Association:
                        return Association;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                MagicEffectWerewolfArchetype_FieldIndex enu = (MagicEffectWerewolfArchetype_FieldIndex)index;
                switch (enu)
                {
                    case MagicEffectWerewolfArchetype_FieldIndex.Association:
                        this.Association = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                MagicEffectWerewolfArchetype_FieldIndex enu = (MagicEffectWerewolfArchetype_FieldIndex)index;
                switch (enu)
                {
                    case MagicEffectWerewolfArchetype_FieldIndex.Association:
                        this.Association = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Association != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public override void Print(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                using (sb.Brace())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        using (sb.Brace())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                    }
                    PrintFillInternal(sb);
                }
            }
            protected override void PrintFillInternal(StructuredStringBuilder sb)
            {
                base.PrintFillInternal(sb);
                {
                    sb.AppendItem(Association, "Association");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Association = this.Association.Combine(rhs.Association);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static new ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public new class TranslationMask :
            AMagicEffectArchetype.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Association;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Association = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Association, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => MagicEffectWerewolfArchetypeCommon.Instance.EnumerateFormLinks(this);
        public override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => MagicEffectWerewolfArchetypeSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectWerewolfArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((MagicEffectWerewolfArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static MagicEffectWerewolfArchetype CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new MagicEffectWerewolfArchetype();
            ((MagicEffectWerewolfArchetypeSetterCommon)((IMagicEffectWerewolfArchetypeGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out MagicEffectWerewolfArchetype item,
            TypedParseParams translationParams = default)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((MagicEffectWerewolfArchetypeSetterCommon)((IMagicEffectWerewolfArchetypeGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new MagicEffectWerewolfArchetype GetNew()
        {
            return new MagicEffectWerewolfArchetype();
        }

    }
    #endregion

    #region Interface
    public partial interface IMagicEffectWerewolfArchetype :
        IAMagicEffectArchetype,
        IFormLinkContainer,
        ILoquiObjectSetter<IMagicEffectWerewolfArchetype>,
        IMagicEffectWerewolfArchetypeGetter
    {
        new IFormLink<IRaceGetter> Association { get; set; }
    }

    public partial interface IMagicEffectWerewolfArchetypeGetter :
        IAMagicEffectArchetypeGetter,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<IMagicEffectWerewolfArchetypeGetter>
    {
        static new ILoquiRegistration StaticRegistration => MagicEffectWerewolfArchetype_Registration.Instance;
        IFormLinkGetter<IRaceGetter> Association { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class MagicEffectWerewolfArchetypeMixIn
    {
        public static void Clear(this IMagicEffectWerewolfArchetype item)
        {
            ((MagicEffectWerewolfArchetypeSetterCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static MagicEffectWerewolfArchetype.Mask<bool> GetEqualsMask(
            this IMagicEffectWerewolfArchetypeGetter item,
            IMagicEffectWerewolfArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IMagicEffectWerewolfArchetypeGetter item,
            string? name = null,
            MagicEffectWerewolfArchetype.Mask<bool>? printMask = null)
        {
            return ((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IMagicEffectWerewolfArchetypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            MagicEffectWerewolfArchetype.Mask<bool>? printMask = null)
        {
            ((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IMagicEffectWerewolfArchetypeGetter item,
            IMagicEffectWerewolfArchetypeGetter rhs,
            MagicEffectWerewolfArchetype.TranslationMask? equalsMask = null)
        {
            return ((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IMagicEffectWerewolfArchetype lhs,
            IMagicEffectWerewolfArchetypeGetter rhs,
            out MagicEffectWerewolfArchetype.ErrorMask errorMask,
            MagicEffectWerewolfArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((MagicEffectWerewolfArchetypeSetterTranslationCommon)((IMagicEffectWerewolfArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = MagicEffectWerewolfArchetype.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IMagicEffectWerewolfArchetype lhs,
            IMagicEffectWerewolfArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((MagicEffectWerewolfArchetypeSetterTranslationCommon)((IMagicEffectWerewolfArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static MagicEffectWerewolfArchetype DeepCopy(
            this IMagicEffectWerewolfArchetypeGetter item,
            MagicEffectWerewolfArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectWerewolfArchetypeSetterTranslationCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static MagicEffectWerewolfArchetype DeepCopy(
            this IMagicEffectWerewolfArchetypeGetter item,
            out MagicEffectWerewolfArchetype.ErrorMask errorMask,
            MagicEffectWerewolfArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectWerewolfArchetypeSetterTranslationCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static MagicEffectWerewolfArchetype DeepCopy(
            this IMagicEffectWerewolfArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((MagicEffectWerewolfArchetypeSetterTranslationCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IMagicEffectWerewolfArchetype item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((MagicEffectWerewolfArchetypeSetterCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    #region Field Index
    internal enum MagicEffectWerewolfArchetype_FieldIndex
    {
        ActorValue = 0,
        Association = 1,
    }
    #endregion

    #region Registration
    internal partial class MagicEffectWerewolfArchetype_Registration : ILoquiRegistration
    {
        public static readonly MagicEffectWerewolfArchetype_Registration Instance = new MagicEffectWerewolfArchetype_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 121,
            version: 0);

        public const string GUID = "92d865d2-52c8-478c-9f36-9eda9540c7c8";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(MagicEffectWerewolfArchetype.Mask<>);

        public static readonly Type ErrorMaskType = typeof(MagicEffectWerewolfArchetype.ErrorMask);

        public static readonly Type ClassType = typeof(MagicEffectWerewolfArchetype);

        public static readonly Type GetterType = typeof(IMagicEffectWerewolfArchetypeGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IMagicEffectWerewolfArchetype);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.MagicEffectWerewolfArchetype";

        public const string Name = "MagicEffectWerewolfArchetype";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(MagicEffectWerewolfArchetypeBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        ushort ILoquiRegistration.FieldCount => FieldCount;
        ushort ILoquiRegistration.AdditionalFieldCount => AdditionalFieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type? ILoquiRegistration.InternalSetterType => InternalSetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type? ILoquiRegistration.InternalGetterType => InternalGetterType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type? ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => throw new NotImplementedException();
        string ILoquiRegistration.GetNthName(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsNthDerivative(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsProtected(ushort index) => throw new NotImplementedException();
        Type ILoquiRegistration.GetNthType(ushort index) => throw new NotImplementedException();
        #endregion

    }
    #endregion

    #region Common
    internal partial class MagicEffectWerewolfArchetypeSetterCommon : AMagicEffectArchetypeSetterCommon
    {
        public new static readonly MagicEffectWerewolfArchetypeSetterCommon Instance = new MagicEffectWerewolfArchetypeSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IMagicEffectWerewolfArchetype item)
        {
            ClearPartial();
            item.Association.Clear();
            base.Clear(item);
        }
        
        public override void Clear(IAMagicEffectArchetype item)
        {
            Clear(item: (IMagicEffectWerewolfArchetype)item);
        }
        
        #region Mutagen
        public void RemapLinks(IMagicEffectWerewolfArchetype obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
            obj.Association.Relink(mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IMagicEffectWerewolfArchetype item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: MagicEffectWerewolfArchetypeBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IAMagicEffectArchetype item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (MagicEffectWerewolfArchetype)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class MagicEffectWerewolfArchetypeCommon : AMagicEffectArchetypeCommon
    {
        public new static readonly MagicEffectWerewolfArchetypeCommon Instance = new MagicEffectWerewolfArchetypeCommon();

        public MagicEffectWerewolfArchetype.Mask<bool> GetEqualsMask(
            IMagicEffectWerewolfArchetypeGetter item,
            IMagicEffectWerewolfArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new MagicEffectWerewolfArchetype.Mask<bool>(false);
            ((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IMagicEffectWerewolfArchetypeGetter item,
            IMagicEffectWerewolfArchetypeGetter rhs,
            MagicEffectWerewolfArchetype.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Association = item.Association.Equals(rhs.Association);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IMagicEffectWerewolfArchetypeGetter item,
            string? name = null,
            MagicEffectWerewolfArchetype.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void Print(
            IMagicEffectWerewolfArchetypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            MagicEffectWerewolfArchetype.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"MagicEffectWerewolfArchetype =>");
            }
            else
            {
                sb.AppendLine($"{name} (MagicEffectWerewolfArchetype) =>");
            }
            using (sb.Brace())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
        }
        
        protected static void ToStringFields(
            IMagicEffectWerewolfArchetypeGetter item,
            StructuredStringBuilder sb,
            MagicEffectWerewolfArchetype.Mask<bool>? printMask = null)
        {
            AMagicEffectArchetypeCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Association ?? true)
            {
                sb.AppendItem(item.Association.FormKey, "Association");
            }
        }
        
        public static MagicEffectWerewolfArchetype_FieldIndex ConvertFieldIndex(AMagicEffectArchetype_FieldIndex index)
        {
            switch (index)
            {
                case AMagicEffectArchetype_FieldIndex.ActorValue:
                    return (MagicEffectWerewolfArchetype_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IMagicEffectWerewolfArchetypeGetter? lhs,
            IMagicEffectWerewolfArchetypeGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IAMagicEffectArchetypeGetter)lhs, (IAMagicEffectArchetypeGetter)rhs, equalsMask)) return false;
            if ((equalsMask?.GetShouldTranslate((int)MagicEffectWerewolfArchetype_FieldIndex.Association) ?? true))
            {
                if (!lhs.Association.Equals(rhs.Association)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IAMagicEffectArchetypeGetter? lhs,
            IAMagicEffectArchetypeGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IMagicEffectWerewolfArchetypeGetter?)lhs,
                rhs: rhs as IMagicEffectWerewolfArchetypeGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IMagicEffectWerewolfArchetypeGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Association);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IAMagicEffectArchetypeGetter item)
        {
            return GetHashCode(item: (IMagicEffectWerewolfArchetypeGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return MagicEffectWerewolfArchetype.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IMagicEffectWerewolfArchetypeGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield return FormLinkInformation.Factory(obj.Association);
            yield break;
        }
        
        #endregion
        
    }
    internal partial class MagicEffectWerewolfArchetypeSetterTranslationCommon : AMagicEffectArchetypeSetterTranslationCommon
    {
        public new static readonly MagicEffectWerewolfArchetypeSetterTranslationCommon Instance = new MagicEffectWerewolfArchetypeSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IMagicEffectWerewolfArchetype item,
            IMagicEffectWerewolfArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IAMagicEffectArchetype)item,
                (IAMagicEffectArchetypeGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)MagicEffectWerewolfArchetype_FieldIndex.Association) ?? true))
            {
                item.Association.SetTo(rhs.Association.FormKey);
            }
        }
        
        
        public override void DeepCopyIn(
            IAMagicEffectArchetype item,
            IAMagicEffectArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IMagicEffectWerewolfArchetype)item,
                rhs: (IMagicEffectWerewolfArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public MagicEffectWerewolfArchetype DeepCopy(
            IMagicEffectWerewolfArchetypeGetter item,
            MagicEffectWerewolfArchetype.TranslationMask? copyMask = null)
        {
            MagicEffectWerewolfArchetype ret = (MagicEffectWerewolfArchetype)((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectWerewolfArchetypeSetterTranslationCommon)((IMagicEffectWerewolfArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public MagicEffectWerewolfArchetype DeepCopy(
            IMagicEffectWerewolfArchetypeGetter item,
            out MagicEffectWerewolfArchetype.ErrorMask errorMask,
            MagicEffectWerewolfArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            MagicEffectWerewolfArchetype ret = (MagicEffectWerewolfArchetype)((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectWerewolfArchetypeSetterTranslationCommon)((IMagicEffectWerewolfArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = MagicEffectWerewolfArchetype.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public MagicEffectWerewolfArchetype DeepCopy(
            IMagicEffectWerewolfArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            MagicEffectWerewolfArchetype ret = (MagicEffectWerewolfArchetype)((MagicEffectWerewolfArchetypeCommon)((IMagicEffectWerewolfArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectWerewolfArchetypeSetterTranslationCommon)((IMagicEffectWerewolfArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: true);
            return ret;
        }
        
    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    public partial class MagicEffectWerewolfArchetype
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectWerewolfArchetype_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => MagicEffectWerewolfArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectWerewolfArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return MagicEffectWerewolfArchetypeSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectWerewolfArchetypeSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class MagicEffectWerewolfArchetypeBinaryWriteTranslation :
        AMagicEffectArchetypeBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly MagicEffectWerewolfArchetypeBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            IMagicEffectWerewolfArchetypeGetter item,
            MutagenWriter writer)
        {
            AMagicEffectArchetypeBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            IMagicEffectWerewolfArchetypeGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IMagicEffectWerewolfArchetypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IAMagicEffectArchetypeGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IMagicEffectWerewolfArchetypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class MagicEffectWerewolfArchetypeBinaryCreateTranslation : AMagicEffectArchetypeBinaryCreateTranslation
    {
        public new static readonly MagicEffectWerewolfArchetypeBinaryCreateTranslation Instance = new MagicEffectWerewolfArchetypeBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IMagicEffectWerewolfArchetype item,
            MutagenFrame frame)
        {
            AMagicEffectArchetypeBinaryCreateTranslation.FillBinaryStructs(
                item: item,
                frame: frame);
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class MagicEffectWerewolfArchetypeBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
}
#endregion

#endregion

