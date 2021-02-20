/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Mutagen.Bethesda.Skyrim.Internals;
using Noggog;
using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class LinkedDoor :
        IEquatable<ILinkedDoorGetter>,
        ILinkedDoor,
        ILoquiObjectSetter<LinkedDoor>
    {
        #region Ctor
        public LinkedDoor()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Unknown
        public Int32 Unknown { get; set; } = default;
        #endregion
        #region Door
        public FormLink<IPlacedObjectGetter> Door { get; set; } = new FormLink<IPlacedObjectGetter>();
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            LinkedDoorMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is ILinkedDoorGetter rhs)) return false;
            return ((LinkedDoorCommon)((ILinkedDoorGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(ILinkedDoorGetter? obj)
        {
            return ((LinkedDoorCommon)((ILinkedDoorGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((LinkedDoorCommon)((ILinkedDoorGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Unknown = initialValue;
                this.Door = initialValue;
            }

            public Mask(
                TItem Unknown,
                TItem Door)
            {
                this.Unknown = Unknown;
                this.Door = Door;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Unknown;
            public TItem Door;
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
                if (!object.Equals(this.Unknown, rhs.Unknown)) return false;
                if (!object.Equals(this.Door, rhs.Door)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Unknown);
                hash.Add(this.Door);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Unknown)) return false;
                if (!eval(this.Door)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Unknown)) return true;
                if (eval(this.Door)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new LinkedDoor.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Unknown = eval(this.Unknown);
                obj.Door = eval(this.Door);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(LinkedDoor.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, LinkedDoor.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(LinkedDoor.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Unknown ?? true)
                    {
                        fg.AppendItem(Unknown, "Unknown");
                    }
                    if (printMask?.Door ?? true)
                    {
                        fg.AppendItem(Door, "Door");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public class ErrorMask :
            IErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Overall { get; set; }
            private List<string>? _warnings;
            public List<string> Warnings
            {
                get
                {
                    if (_warnings == null)
                    {
                        _warnings = new List<string>();
                    }
                    return _warnings;
                }
            }
            public Exception? Unknown;
            public Exception? Door;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                LinkedDoor_FieldIndex enu = (LinkedDoor_FieldIndex)index;
                switch (enu)
                {
                    case LinkedDoor_FieldIndex.Unknown:
                        return Unknown;
                    case LinkedDoor_FieldIndex.Door:
                        return Door;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                LinkedDoor_FieldIndex enu = (LinkedDoor_FieldIndex)index;
                switch (enu)
                {
                    case LinkedDoor_FieldIndex.Unknown:
                        this.Unknown = ex;
                        break;
                    case LinkedDoor_FieldIndex.Door:
                        this.Door = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                LinkedDoor_FieldIndex enu = (LinkedDoor_FieldIndex)index;
                switch (enu)
                {
                    case LinkedDoor_FieldIndex.Unknown:
                        this.Unknown = (Exception?)obj;
                        break;
                    case LinkedDoor_FieldIndex.Door:
                        this.Door = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Unknown != null) return true;
                if (Door != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString()
            {
                var fg = new FileGeneration();
                ToString(fg, null);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, string? name = null)
            {
                fg.AppendLine($"{(name ?? "ErrorMask")} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (this.Overall != null)
                    {
                        fg.AppendLine("Overall =>");
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            fg.AppendLine($"{this.Overall}");
                        }
                        fg.AppendLine("]");
                    }
                    ToString_FillInternal(fg);
                }
                fg.AppendLine("]");
            }
            protected void ToString_FillInternal(FileGeneration fg)
            {
                fg.AppendItem(Unknown, "Unknown");
                fg.AppendItem(Door, "Door");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Unknown = this.Unknown.Combine(rhs.Unknown);
                ret.Door = this.Door.Combine(rhs.Door);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public class TranslationMask : ITranslationMask
        {
            #region Members
            private TranslationCrystal? _crystal;
            public readonly bool DefaultOn;
            public bool OnOverall;
            public bool Unknown;
            public bool Door;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Unknown = defaultOn;
                this.Door = defaultOn;
            }

            #endregion

            public TranslationCrystal GetCrystal()
            {
                if (_crystal != null) return _crystal;
                var ret = new List<(bool On, TranslationCrystal? SubCrystal)>();
                GetCrystal(ret);
                _crystal = new TranslationCrystal(ret.ToArray());
                return _crystal;
            }

            protected void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                ret.Add((Unknown, null));
                ret.Add((Door, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public IEnumerable<FormLinkInformation> ContainedFormLinks => LinkedDoorCommon.Instance.GetContainedFormLinks(this);
        public void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => LinkedDoorSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => LinkedDoorBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((LinkedDoorBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public static LinkedDoor CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new LinkedDoor();
            ((LinkedDoorSetterCommon)((ILinkedDoorGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out LinkedDoor item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(frame, recordTypeConverter);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((LinkedDoorSetterCommon)((ILinkedDoorGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static LinkedDoor GetNew()
        {
            return new LinkedDoor();
        }

    }
    #endregion

    #region Interface
    public partial interface ILinkedDoor :
        IFormLinkContainer,
        ILinkedDoorGetter,
        ILoquiObjectSetter<ILinkedDoor>
    {
        new Int32 Unknown { get; set; }
        new FormLink<IPlacedObjectGetter> Door { get; set; }
    }

    public partial interface ILinkedDoorGetter :
        ILoquiObject,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<ILinkedDoorGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => LinkedDoor_Registration.Instance;
        Int32 Unknown { get; }
        FormLink<IPlacedObjectGetter> Door { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class LinkedDoorMixIn
    {
        public static void Clear(this ILinkedDoor item)
        {
            ((LinkedDoorSetterCommon)((ILinkedDoorGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static LinkedDoor.Mask<bool> GetEqualsMask(
            this ILinkedDoorGetter item,
            ILinkedDoorGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((LinkedDoorCommon)((ILinkedDoorGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this ILinkedDoorGetter item,
            string? name = null,
            LinkedDoor.Mask<bool>? printMask = null)
        {
            return ((LinkedDoorCommon)((ILinkedDoorGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this ILinkedDoorGetter item,
            FileGeneration fg,
            string? name = null,
            LinkedDoor.Mask<bool>? printMask = null)
        {
            ((LinkedDoorCommon)((ILinkedDoorGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this ILinkedDoorGetter item,
            ILinkedDoorGetter rhs)
        {
            return ((LinkedDoorCommon)((ILinkedDoorGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this ILinkedDoor lhs,
            ILinkedDoorGetter rhs)
        {
            ((LinkedDoorSetterTranslationCommon)((ILinkedDoorGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this ILinkedDoor lhs,
            ILinkedDoorGetter rhs,
            LinkedDoor.TranslationMask? copyMask = null)
        {
            ((LinkedDoorSetterTranslationCommon)((ILinkedDoorGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this ILinkedDoor lhs,
            ILinkedDoorGetter rhs,
            out LinkedDoor.ErrorMask errorMask,
            LinkedDoor.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((LinkedDoorSetterTranslationCommon)((ILinkedDoorGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = LinkedDoor.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this ILinkedDoor lhs,
            ILinkedDoorGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((LinkedDoorSetterTranslationCommon)((ILinkedDoorGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static LinkedDoor DeepCopy(
            this ILinkedDoorGetter item,
            LinkedDoor.TranslationMask? copyMask = null)
        {
            return ((LinkedDoorSetterTranslationCommon)((ILinkedDoorGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static LinkedDoor DeepCopy(
            this ILinkedDoorGetter item,
            out LinkedDoor.ErrorMask errorMask,
            LinkedDoor.TranslationMask? copyMask = null)
        {
            return ((LinkedDoorSetterTranslationCommon)((ILinkedDoorGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static LinkedDoor DeepCopy(
            this ILinkedDoorGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((LinkedDoorSetterTranslationCommon)((ILinkedDoorGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this ILinkedDoor item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((LinkedDoorSetterCommon)((ILinkedDoorGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Internals
{
    #region Field Index
    public enum LinkedDoor_FieldIndex
    {
        Unknown = 0,
        Door = 1,
    }
    #endregion

    #region Registration
    public partial class LinkedDoor_Registration : ILoquiRegistration
    {
        public static readonly LinkedDoor_Registration Instance = new LinkedDoor_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 275,
            version: 0);

        public const string GUID = "47c9da10-da3e-4e0b-b735-a20fa8632f68";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(LinkedDoor.Mask<>);

        public static readonly Type ErrorMaskType = typeof(LinkedDoor.ErrorMask);

        public static readonly Type ClassType = typeof(LinkedDoor);

        public static readonly Type GetterType = typeof(ILinkedDoorGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(ILinkedDoor);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.LinkedDoor";

        public const string Name = "LinkedDoor";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(LinkedDoorBinaryWriteTranslation);
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
    public partial class LinkedDoorSetterCommon
    {
        public static readonly LinkedDoorSetterCommon Instance = new LinkedDoorSetterCommon();

        partial void ClearPartial();
        
        public void Clear(ILinkedDoor item)
        {
            ClearPartial();
            item.Unknown = default;
            item.Door = FormLink<IPlacedObjectGetter>.Null;
        }
        
        #region Mutagen
        public void RemapLinks(ILinkedDoor obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            obj.Door.Relink(mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            ILinkedDoor item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: LinkedDoorBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    public partial class LinkedDoorCommon
    {
        public static readonly LinkedDoorCommon Instance = new LinkedDoorCommon();

        public LinkedDoor.Mask<bool> GetEqualsMask(
            ILinkedDoorGetter item,
            ILinkedDoorGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new LinkedDoor.Mask<bool>(false);
            ((LinkedDoorCommon)((ILinkedDoorGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            ILinkedDoorGetter item,
            ILinkedDoorGetter rhs,
            LinkedDoor.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Unknown = item.Unknown == rhs.Unknown;
            ret.Door = item.Door.Equals(rhs.Door);
        }
        
        public string ToString(
            ILinkedDoorGetter item,
            string? name = null,
            LinkedDoor.Mask<bool>? printMask = null)
        {
            var fg = new FileGeneration();
            ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
            return fg.ToString();
        }
        
        public void ToString(
            ILinkedDoorGetter item,
            FileGeneration fg,
            string? name = null,
            LinkedDoor.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"LinkedDoor =>");
            }
            else
            {
                fg.AppendLine($"{name} (LinkedDoor) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                ToStringFields(
                    item: item,
                    fg: fg,
                    printMask: printMask);
            }
            fg.AppendLine("]");
        }
        
        protected static void ToStringFields(
            ILinkedDoorGetter item,
            FileGeneration fg,
            LinkedDoor.Mask<bool>? printMask = null)
        {
            if (printMask?.Unknown ?? true)
            {
                fg.AppendItem(item.Unknown, "Unknown");
            }
            if (printMask?.Door ?? true)
            {
                fg.AppendItem(item.Door.FormKey, "Door");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            ILinkedDoorGetter? lhs,
            ILinkedDoorGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (lhs.Unknown != rhs.Unknown) return false;
            if (!lhs.Door.Equals(rhs.Door)) return false;
            return true;
        }
        
        public virtual int GetHashCode(ILinkedDoorGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Unknown);
            hash.Add(item.Door);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return LinkedDoor.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(ILinkedDoorGetter obj)
        {
            yield return FormLinkInformation.Factory(obj.Door);
            yield break;
        }
        
        #endregion
        
    }
    public partial class LinkedDoorSetterTranslationCommon
    {
        public static readonly LinkedDoorSetterTranslationCommon Instance = new LinkedDoorSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            ILinkedDoor item,
            ILinkedDoorGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)LinkedDoor_FieldIndex.Unknown) ?? true))
            {
                item.Unknown = rhs.Unknown;
            }
            if ((copyMask?.GetShouldTranslate((int)LinkedDoor_FieldIndex.Door) ?? true))
            {
                item.Door = new FormLink<IPlacedObjectGetter>(rhs.Door.FormKey);
            }
        }
        
        #endregion
        
        public LinkedDoor DeepCopy(
            ILinkedDoorGetter item,
            LinkedDoor.TranslationMask? copyMask = null)
        {
            LinkedDoor ret = (LinkedDoor)((LinkedDoorCommon)((ILinkedDoorGetter)item).CommonInstance()!).GetNew();
            ((LinkedDoorSetterTranslationCommon)((ILinkedDoorGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public LinkedDoor DeepCopy(
            ILinkedDoorGetter item,
            out LinkedDoor.ErrorMask errorMask,
            LinkedDoor.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            LinkedDoor ret = (LinkedDoor)((LinkedDoorCommon)((ILinkedDoorGetter)item).CommonInstance()!).GetNew();
            ((LinkedDoorSetterTranslationCommon)((ILinkedDoorGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = LinkedDoor.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public LinkedDoor DeepCopy(
            ILinkedDoorGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            LinkedDoor ret = (LinkedDoor)((LinkedDoorCommon)((ILinkedDoorGetter)item).CommonInstance()!).GetNew();
            ((LinkedDoorSetterTranslationCommon)((ILinkedDoorGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class LinkedDoor
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => LinkedDoor_Registration.Instance;
        public static LinkedDoor_Registration Registration => LinkedDoor_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => LinkedDoorCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return LinkedDoorSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => LinkedDoorSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object ILinkedDoorGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object ILinkedDoorGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object ILinkedDoorGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class LinkedDoorBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static LinkedDoorBinaryWriteTranslation Instance = new LinkedDoorBinaryWriteTranslation();

        public static void WriteEmbedded(
            ILinkedDoorGetter item,
            MutagenWriter writer)
        {
            writer.Write(item.Unknown);
            Mutagen.Bethesda.Binary.FormLinkBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Door);
        }

        public void Write(
            MutagenWriter writer,
            ILinkedDoorGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (ILinkedDoorGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class LinkedDoorBinaryCreateTranslation
    {
        public readonly static LinkedDoorBinaryCreateTranslation Instance = new LinkedDoorBinaryCreateTranslation();

        public static void FillBinaryStructs(
            ILinkedDoor item,
            MutagenFrame frame)
        {
            item.Unknown = frame.ReadInt32();
            item.Door = Mutagen.Bethesda.Binary.FormLinkBinaryTranslation.Instance.Parse(
                frame: frame,
                defaultVal: FormKey.Null);
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class LinkedDoorBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this ILinkedDoorGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((LinkedDoorBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class LinkedDoorBinaryOverlay :
        BinaryOverlay,
        ILinkedDoorGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => LinkedDoor_Registration.Instance;
        public static LinkedDoor_Registration Registration => LinkedDoor_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => LinkedDoorCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => LinkedDoorSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object ILinkedDoorGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? ILinkedDoorGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object ILinkedDoorGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        public IEnumerable<FormLinkInformation> ContainedFormLinks => LinkedDoorCommon.Instance.GetContainedFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => LinkedDoorBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((LinkedDoorBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public Int32 Unknown => BinaryPrimitives.ReadInt32LittleEndian(_data.Slice(0x0, 0x4));
        public FormLink<IPlacedObjectGetter> Door => new FormLink<IPlacedObjectGetter>(FormKey.Factory(_package.MetaData.MasterReferences!, BinaryPrimitives.ReadUInt32LittleEndian(_data.Span.Slice(0x4, 0x4))));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected LinkedDoorBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static LinkedDoorBinaryOverlay LinkedDoorFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new LinkedDoorBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x8),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x8;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static LinkedDoorBinaryOverlay LinkedDoorFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return LinkedDoorFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            LinkedDoorMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is ILinkedDoorGetter rhs)) return false;
            return ((LinkedDoorCommon)((ILinkedDoorGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(ILinkedDoorGetter? obj)
        {
            return ((LinkedDoorCommon)((ILinkedDoorGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((LinkedDoorCommon)((ILinkedDoorGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

