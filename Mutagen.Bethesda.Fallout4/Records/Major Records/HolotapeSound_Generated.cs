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
using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Fallout4.Internals;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Fallout4.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Fallout4.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Fallout4
{
    #region Class
    public partial class HolotapeSound :
        AHolotapeData,
        IEquatable<IHolotapeSoundGetter>,
        IHolotapeSound,
        ILoquiObjectSetter<HolotapeSound>
    {
        #region Ctor
        public HolotapeSound()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Sound
        private readonly IFormLink<ISoundDescriptorGetter> _Sound = new FormLink<ISoundDescriptorGetter>();
        public IFormLink<ISoundDescriptorGetter> Sound
        {
            get => _Sound;
            set => _Sound.SetTo(value);
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IFormLinkGetter<ISoundDescriptorGetter> IHolotapeSoundGetter.Sound => this.Sound;
        #endregion

        #region To String

        public override void ToString(
            StructuredStringBuilder sb,
            string? name = null)
        {
            HolotapeSoundMixIn.ToString(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IHolotapeSoundGetter rhs) return false;
            return ((HolotapeSoundCommon)((IHolotapeSoundGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IHolotapeSoundGetter? obj)
        {
            return ((HolotapeSoundCommon)((IHolotapeSoundGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((HolotapeSoundCommon)((IHolotapeSoundGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            AHolotapeData.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem Sound)
            : base()
            {
                this.Sound = Sound;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Sound;
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
                if (!object.Equals(this.Sound, rhs.Sound)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Sound);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Sound)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Sound)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new HolotapeSound.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Sound = eval(this.Sound);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(HolotapeSound.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                ToString(sb, printMask);
                return sb.ToString();
            }

            public void ToString(StructuredStringBuilder sb, HolotapeSound.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(HolotapeSound.Mask<TItem>)} =>");
                sb.AppendLine("[");
                using (sb.IncreaseDepth())
                {
                    if (printMask?.Sound ?? true)
                    {
                        sb.AppendItem(Sound, "Sound");
                    }
                }
                sb.AppendLine("]");
            }
            #endregion

        }

        public new class ErrorMask :
            AHolotapeData.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Sound;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                HolotapeSound_FieldIndex enu = (HolotapeSound_FieldIndex)index;
                switch (enu)
                {
                    case HolotapeSound_FieldIndex.Sound:
                        return Sound;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                HolotapeSound_FieldIndex enu = (HolotapeSound_FieldIndex)index;
                switch (enu)
                {
                    case HolotapeSound_FieldIndex.Sound:
                        this.Sound = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                HolotapeSound_FieldIndex enu = (HolotapeSound_FieldIndex)index;
                switch (enu)
                {
                    case HolotapeSound_FieldIndex.Sound:
                        this.Sound = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Sound != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString()
            {
                var sb = new StructuredStringBuilder();
                ToString(sb, null);
                return sb.ToString();
            }

            public override void ToString(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                sb.AppendLine("[");
                using (sb.IncreaseDepth())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        sb.AppendLine("[");
                        using (sb.IncreaseDepth())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                        sb.AppendLine("]");
                    }
                    ToString_FillInternal(sb);
                }
                sb.AppendLine("]");
            }
            protected override void ToString_FillInternal(StructuredStringBuilder sb)
            {
                base.ToString_FillInternal(sb);
                {
                    sb.AppendItem(Sound, "Sound");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Sound = this.Sound.Combine(rhs.Sound);
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
            AHolotapeData.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Sound;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Sound = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Sound, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public override IEnumerable<IFormLinkGetter> ContainedFormLinks => HolotapeSoundCommon.Instance.GetContainedFormLinks(this);
        public override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => HolotapeSoundSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => HolotapeSoundBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((HolotapeSoundBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static HolotapeSound CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new HolotapeSound();
            ((HolotapeSoundSetterCommon)((IHolotapeSoundGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out HolotapeSound item,
            TypedParseParams? translationParams = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(StructuredStringBuilder sb, string? name) => this.ToString(sb, name);

        void IClearable.Clear()
        {
            ((HolotapeSoundSetterCommon)((IHolotapeSoundGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new HolotapeSound GetNew()
        {
            return new HolotapeSound();
        }

    }
    #endregion

    #region Interface
    public partial interface IHolotapeSound :
        IAHolotapeData,
        IFormLinkContainer,
        IHolotapeSoundGetter,
        ILoquiObjectSetter<IHolotapeSound>
    {
        new IFormLink<ISoundDescriptorGetter> Sound { get; set; }
    }

    public partial interface IHolotapeSoundGetter :
        IAHolotapeDataGetter,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<IHolotapeSoundGetter>
    {
        static new ILoquiRegistration StaticRegistration => HolotapeSound_Registration.Instance;
        IFormLinkGetter<ISoundDescriptorGetter> Sound { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class HolotapeSoundMixIn
    {
        public static void Clear(this IHolotapeSound item)
        {
            ((HolotapeSoundSetterCommon)((IHolotapeSoundGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static HolotapeSound.Mask<bool> GetEqualsMask(
            this IHolotapeSoundGetter item,
            IHolotapeSoundGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((HolotapeSoundCommon)((IHolotapeSoundGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IHolotapeSoundGetter item,
            string? name = null,
            HolotapeSound.Mask<bool>? printMask = null)
        {
            return ((HolotapeSoundCommon)((IHolotapeSoundGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IHolotapeSoundGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            HolotapeSound.Mask<bool>? printMask = null)
        {
            ((HolotapeSoundCommon)((IHolotapeSoundGetter)item).CommonInstance()!).ToString(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IHolotapeSoundGetter item,
            IHolotapeSoundGetter rhs,
            HolotapeSound.TranslationMask? equalsMask = null)
        {
            return ((HolotapeSoundCommon)((IHolotapeSoundGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IHolotapeSound lhs,
            IHolotapeSoundGetter rhs,
            out HolotapeSound.ErrorMask errorMask,
            HolotapeSound.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((HolotapeSoundSetterTranslationCommon)((IHolotapeSoundGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = HolotapeSound.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IHolotapeSound lhs,
            IHolotapeSoundGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((HolotapeSoundSetterTranslationCommon)((IHolotapeSoundGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static HolotapeSound DeepCopy(
            this IHolotapeSoundGetter item,
            HolotapeSound.TranslationMask? copyMask = null)
        {
            return ((HolotapeSoundSetterTranslationCommon)((IHolotapeSoundGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static HolotapeSound DeepCopy(
            this IHolotapeSoundGetter item,
            out HolotapeSound.ErrorMask errorMask,
            HolotapeSound.TranslationMask? copyMask = null)
        {
            return ((HolotapeSoundSetterTranslationCommon)((IHolotapeSoundGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static HolotapeSound DeepCopy(
            this IHolotapeSoundGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((HolotapeSoundSetterTranslationCommon)((IHolotapeSoundGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IHolotapeSound item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((HolotapeSoundSetterCommon)((IHolotapeSoundGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Fallout4
{
    #region Field Index
    internal enum HolotapeSound_FieldIndex
    {
        Sound = 0,
    }
    #endregion

    #region Registration
    internal partial class HolotapeSound_Registration : ILoquiRegistration
    {
        public static readonly HolotapeSound_Registration Instance = new HolotapeSound_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 353,
            version: 0);

        public const string GUID = "e667cb0b-dcdc-40b9-9b73-b740758f9e50";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(HolotapeSound.Mask<>);

        public static readonly Type ErrorMaskType = typeof(HolotapeSound.ErrorMask);

        public static readonly Type ClassType = typeof(HolotapeSound);

        public static readonly Type GetterType = typeof(IHolotapeSoundGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IHolotapeSound);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.HolotapeSound";

        public const string Name = "HolotapeSound";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(HolotapeSoundBinaryWriteTranslation);
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
    internal partial class HolotapeSoundSetterCommon : AHolotapeDataSetterCommon
    {
        public new static readonly HolotapeSoundSetterCommon Instance = new HolotapeSoundSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IHolotapeSound item)
        {
            ClearPartial();
            item.Sound.Clear();
            base.Clear(item);
        }
        
        public override void Clear(IAHolotapeData item)
        {
            Clear(item: (IHolotapeSound)item);
        }
        
        #region Mutagen
        public void RemapLinks(IHolotapeSound obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
            obj.Sound.Relink(mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IHolotapeSound item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: HolotapeSoundBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IAHolotapeData item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            CopyInFromBinary(
                item: (HolotapeSound)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class HolotapeSoundCommon : AHolotapeDataCommon
    {
        public new static readonly HolotapeSoundCommon Instance = new HolotapeSoundCommon();

        public HolotapeSound.Mask<bool> GetEqualsMask(
            IHolotapeSoundGetter item,
            IHolotapeSoundGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new HolotapeSound.Mask<bool>(false);
            ((HolotapeSoundCommon)((IHolotapeSoundGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IHolotapeSoundGetter item,
            IHolotapeSoundGetter rhs,
            HolotapeSound.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Sound = item.Sound.Equals(rhs.Sound);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            IHolotapeSoundGetter item,
            string? name = null,
            HolotapeSound.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            ToString(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void ToString(
            IHolotapeSoundGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            HolotapeSound.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"HolotapeSound =>");
            }
            else
            {
                sb.AppendLine($"{name} (HolotapeSound) =>");
            }
            sb.AppendLine("[");
            using (sb.IncreaseDepth())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
            sb.AppendLine("]");
        }
        
        protected static void ToStringFields(
            IHolotapeSoundGetter item,
            StructuredStringBuilder sb,
            HolotapeSound.Mask<bool>? printMask = null)
        {
            AHolotapeDataCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Sound ?? true)
            {
                sb.AppendItem(item.Sound.FormKey, "Sound");
            }
        }
        
        public static HolotapeSound_FieldIndex ConvertFieldIndex(AHolotapeData_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IHolotapeSoundGetter? lhs,
            IHolotapeSoundGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IAHolotapeDataGetter)lhs, (IAHolotapeDataGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)HolotapeSound_FieldIndex.Sound) ?? true))
            {
                if (!lhs.Sound.Equals(rhs.Sound)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IAHolotapeDataGetter? lhs,
            IAHolotapeDataGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IHolotapeSoundGetter?)lhs,
                rhs: rhs as IHolotapeSoundGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IHolotapeSoundGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Sound);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IAHolotapeDataGetter item)
        {
            return GetHashCode(item: (IHolotapeSoundGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return HolotapeSound.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> GetContainedFormLinks(IHolotapeSoundGetter obj)
        {
            foreach (var item in base.GetContainedFormLinks(obj))
            {
                yield return item;
            }
            yield return FormLinkInformation.Factory(obj.Sound);
            yield break;
        }
        
        #endregion
        
    }
    internal partial class HolotapeSoundSetterTranslationCommon : AHolotapeDataSetterTranslationCommon
    {
        public new static readonly HolotapeSoundSetterTranslationCommon Instance = new HolotapeSoundSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IHolotapeSound item,
            IHolotapeSoundGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IAHolotapeData)item,
                (IAHolotapeDataGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)HolotapeSound_FieldIndex.Sound) ?? true))
            {
                item.Sound.SetTo(rhs.Sound.FormKey);
            }
        }
        
        
        public override void DeepCopyIn(
            IAHolotapeData item,
            IAHolotapeDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IHolotapeSound)item,
                rhs: (IHolotapeSoundGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public HolotapeSound DeepCopy(
            IHolotapeSoundGetter item,
            HolotapeSound.TranslationMask? copyMask = null)
        {
            HolotapeSound ret = (HolotapeSound)((HolotapeSoundCommon)((IHolotapeSoundGetter)item).CommonInstance()!).GetNew();
            ((HolotapeSoundSetterTranslationCommon)((IHolotapeSoundGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public HolotapeSound DeepCopy(
            IHolotapeSoundGetter item,
            out HolotapeSound.ErrorMask errorMask,
            HolotapeSound.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            HolotapeSound ret = (HolotapeSound)((HolotapeSoundCommon)((IHolotapeSoundGetter)item).CommonInstance()!).GetNew();
            ((HolotapeSoundSetterTranslationCommon)((IHolotapeSoundGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = HolotapeSound.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public HolotapeSound DeepCopy(
            IHolotapeSoundGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            HolotapeSound ret = (HolotapeSound)((HolotapeSoundCommon)((IHolotapeSoundGetter)item).CommonInstance()!).GetNew();
            ((HolotapeSoundSetterTranslationCommon)((IHolotapeSoundGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Fallout4
{
    public partial class HolotapeSound
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => HolotapeSound_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => HolotapeSound_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => HolotapeSoundCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return HolotapeSoundSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => HolotapeSoundSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class HolotapeSoundBinaryWriteTranslation :
        AHolotapeDataBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static HolotapeSoundBinaryWriteTranslation Instance = new HolotapeSoundBinaryWriteTranslation();

        public static void WriteEmbedded(
            IHolotapeSoundGetter item,
            MutagenWriter writer)
        {
            FormLinkBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Sound);
        }

        public void Write(
            MutagenWriter writer,
            IHolotapeSoundGetter item,
            TypedWriteParams? translationParams = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IHolotapeSoundGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IAHolotapeDataGetter item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IHolotapeSoundGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class HolotapeSoundBinaryCreateTranslation : AHolotapeDataBinaryCreateTranslation
    {
        public new readonly static HolotapeSoundBinaryCreateTranslation Instance = new HolotapeSoundBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IHolotapeSound item,
            MutagenFrame frame)
        {
            item.Sound.SetTo(FormLinkBinaryTranslation.Instance.Parse(reader: frame));
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class HolotapeSoundBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class HolotapeSoundBinaryOverlay :
        AHolotapeDataBinaryOverlay,
        IHolotapeSoundGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => HolotapeSound_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => HolotapeSound_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => HolotapeSoundCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => HolotapeSoundSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.ToString(StructuredStringBuilder sb, string? name) => this.ToString(sb, name);

        public override IEnumerable<IFormLinkGetter> ContainedFormLinks => HolotapeSoundCommon.Instance.GetContainedFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => HolotapeSoundBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((HolotapeSoundBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public IFormLinkGetter<ISoundDescriptorGetter> Sound => new FormLink<ISoundDescriptorGetter>(FormKey.Factory(_package.MetaData.MasterReferences!, BinaryPrimitives.ReadUInt32LittleEndian(_data.Span.Slice(0x0, 0x4))));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected HolotapeSoundBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static HolotapeSoundBinaryOverlay HolotapeSoundFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            var ret = new HolotapeSoundBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x4),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static HolotapeSoundBinaryOverlay HolotapeSoundFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            return HolotapeSoundFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                parseParams: parseParams);
        }

        #region To String

        public override void ToString(
            StructuredStringBuilder sb,
            string? name = null)
        {
            HolotapeSoundMixIn.ToString(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IHolotapeSoundGetter rhs) return false;
            return ((HolotapeSoundCommon)((IHolotapeSoundGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IHolotapeSoundGetter? obj)
        {
            return ((HolotapeSoundCommon)((IHolotapeSoundGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((HolotapeSoundCommon)((IHolotapeSoundGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

