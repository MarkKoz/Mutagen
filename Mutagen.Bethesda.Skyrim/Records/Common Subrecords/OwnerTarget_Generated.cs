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
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
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
    /// <summary>
    /// Implemented by: [NpcOwner, FactionOwner, NoOwner]
    /// </summary>
    public abstract partial class OwnerTarget :
        IEquatable<IOwnerTargetGetter>,
        ILoquiObjectSetter<OwnerTarget>,
        IOwnerTarget
    {
        #region Ctor
        public OwnerTarget()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public virtual void ToString(
            FileGeneration fg,
            string? name = null)
        {
            OwnerTargetMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IOwnerTargetGetter rhs) return false;
            return ((OwnerTargetCommon)((IOwnerTargetGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IOwnerTargetGetter? obj)
        {
            return ((OwnerTargetCommon)((IOwnerTargetGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((OwnerTargetCommon)((IOwnerTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
            }


            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

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
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public virtual bool All(Func<TItem, bool> eval)
            {
                return true;
            }
            #endregion

            #region Any
            public virtual bool Any(Func<TItem, bool> eval)
            {
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new OwnerTarget.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(OwnerTarget.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, OwnerTarget.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(OwnerTarget.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
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
            #endregion

            #region IErrorMask
            public virtual object? GetNthMask(int index)
            {
                OwnerTarget_FieldIndex enu = (OwnerTarget_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthException(int index, Exception ex)
            {
                OwnerTarget_FieldIndex enu = (OwnerTarget_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthMask(int index, object obj)
            {
                OwnerTarget_FieldIndex enu = (OwnerTarget_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual bool IsInError()
            {
                if (Overall != null) return true;
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

            public virtual void ToString(FileGeneration fg, string? name = null)
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
            protected virtual void ToString_FillInternal(FileGeneration fg)
            {
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
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
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
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

            protected virtual void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public virtual IEnumerable<IFormLinkGetter> ContainedFormLinks => OwnerTargetCommon.Instance.GetContainedFormLinks(this);
        public virtual void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => OwnerTargetSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => OwnerTargetBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((OwnerTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((OwnerTargetSetterCommon)((IOwnerTargetGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static OwnerTarget GetNew()
        {
            throw new ArgumentException("New called on an abstract class.");
        }

    }
    #endregion

    #region Interface
    /// <summary>
    /// Implemented by: [NpcOwner, FactionOwner, NoOwner]
    /// </summary>
    public partial interface IOwnerTarget :
        IFormLinkContainer,
        ILoquiObjectSetter<IOwnerTarget>,
        IOwnerTargetGetter
    {
    }

    /// <summary>
    /// Implemented by: [NpcOwner, FactionOwner, NoOwner]
    /// </summary>
    public partial interface IOwnerTargetGetter :
        ILoquiObject,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<IOwnerTargetGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => OwnerTarget_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class OwnerTargetMixIn
    {
        public static void Clear(this IOwnerTarget item)
        {
            ((OwnerTargetSetterCommon)((IOwnerTargetGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static OwnerTarget.Mask<bool> GetEqualsMask(
            this IOwnerTargetGetter item,
            IOwnerTargetGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((OwnerTargetCommon)((IOwnerTargetGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IOwnerTargetGetter item,
            string? name = null,
            OwnerTarget.Mask<bool>? printMask = null)
        {
            return ((OwnerTargetCommon)((IOwnerTargetGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IOwnerTargetGetter item,
            FileGeneration fg,
            string? name = null,
            OwnerTarget.Mask<bool>? printMask = null)
        {
            ((OwnerTargetCommon)((IOwnerTargetGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IOwnerTargetGetter item,
            IOwnerTargetGetter rhs,
            OwnerTarget.TranslationMask? equalsMask = null)
        {
            return ((OwnerTargetCommon)((IOwnerTargetGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IOwnerTarget lhs,
            IOwnerTargetGetter rhs)
        {
            ((OwnerTargetSetterTranslationCommon)((IOwnerTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IOwnerTarget lhs,
            IOwnerTargetGetter rhs,
            OwnerTarget.TranslationMask? copyMask = null)
        {
            ((OwnerTargetSetterTranslationCommon)((IOwnerTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IOwnerTarget lhs,
            IOwnerTargetGetter rhs,
            out OwnerTarget.ErrorMask errorMask,
            OwnerTarget.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((OwnerTargetSetterTranslationCommon)((IOwnerTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = OwnerTarget.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IOwnerTarget lhs,
            IOwnerTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((OwnerTargetSetterTranslationCommon)((IOwnerTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static OwnerTarget DeepCopy(
            this IOwnerTargetGetter item,
            OwnerTarget.TranslationMask? copyMask = null)
        {
            return ((OwnerTargetSetterTranslationCommon)((IOwnerTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static OwnerTarget DeepCopy(
            this IOwnerTargetGetter item,
            out OwnerTarget.ErrorMask errorMask,
            OwnerTarget.TranslationMask? copyMask = null)
        {
            return ((OwnerTargetSetterTranslationCommon)((IOwnerTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static OwnerTarget DeepCopy(
            this IOwnerTargetGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((OwnerTargetSetterTranslationCommon)((IOwnerTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IOwnerTarget item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((OwnerTargetSetterCommon)((IOwnerTargetGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Internals
{
    #region Field Index
    public enum OwnerTarget_FieldIndex
    {
    }
    #endregion

    #region Registration
    public partial class OwnerTarget_Registration : ILoquiRegistration
    {
        public static readonly OwnerTarget_Registration Instance = new OwnerTarget_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 174,
            version: 0);

        public const string GUID = "9b370639-8ecf-4dae-9904-3c431abedb79";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 0;

        public static readonly Type MaskType = typeof(OwnerTarget.Mask<>);

        public static readonly Type ErrorMaskType = typeof(OwnerTarget.ErrorMask);

        public static readonly Type ClassType = typeof(OwnerTarget);

        public static readonly Type GetterType = typeof(IOwnerTargetGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IOwnerTarget);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.OwnerTarget";

        public const string Name = "OwnerTarget";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(OwnerTargetBinaryWriteTranslation);
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
    public partial class OwnerTargetSetterCommon
    {
        public static readonly OwnerTargetSetterCommon Instance = new OwnerTargetSetterCommon();

        partial void ClearPartial();
        
        public virtual void Clear(IOwnerTarget item)
        {
            ClearPartial();
        }
        
        #region Mutagen
        public void RemapLinks(IOwnerTarget obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IOwnerTarget item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
        }
        
        #endregion
        
    }
    public partial class OwnerTargetCommon
    {
        public static readonly OwnerTargetCommon Instance = new OwnerTargetCommon();

        public OwnerTarget.Mask<bool> GetEqualsMask(
            IOwnerTargetGetter item,
            IOwnerTargetGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new OwnerTarget.Mask<bool>(false);
            ((OwnerTargetCommon)((IOwnerTargetGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IOwnerTargetGetter item,
            IOwnerTargetGetter rhs,
            OwnerTarget.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
        }
        
        public string ToString(
            IOwnerTargetGetter item,
            string? name = null,
            OwnerTarget.Mask<bool>? printMask = null)
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
            IOwnerTargetGetter item,
            FileGeneration fg,
            string? name = null,
            OwnerTarget.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"OwnerTarget =>");
            }
            else
            {
                fg.AppendLine($"{name} (OwnerTarget) =>");
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
            IOwnerTargetGetter item,
            FileGeneration fg,
            OwnerTarget.Mask<bool>? printMask = null)
        {
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IOwnerTargetGetter? lhs,
            IOwnerTargetGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            return true;
        }
        
        public virtual int GetHashCode(IOwnerTargetGetter item)
        {
            var hash = new HashCode();
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public virtual object GetNew()
        {
            return OwnerTarget.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> GetContainedFormLinks(IOwnerTargetGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    public partial class OwnerTargetSetterTranslationCommon
    {
        public static readonly OwnerTargetSetterTranslationCommon Instance = new OwnerTargetSetterTranslationCommon();

        #region DeepCopyIn
        public virtual void DeepCopyIn(
            IOwnerTarget item,
            IOwnerTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
        }
        
        #endregion
        
        public OwnerTarget DeepCopy(
            IOwnerTargetGetter item,
            OwnerTarget.TranslationMask? copyMask = null)
        {
            OwnerTarget ret = (OwnerTarget)((OwnerTargetCommon)((IOwnerTargetGetter)item).CommonInstance()!).GetNew();
            ((OwnerTargetSetterTranslationCommon)((IOwnerTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public OwnerTarget DeepCopy(
            IOwnerTargetGetter item,
            out OwnerTarget.ErrorMask errorMask,
            OwnerTarget.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            OwnerTarget ret = (OwnerTarget)((OwnerTargetCommon)((IOwnerTargetGetter)item).CommonInstance()!).GetNew();
            ((OwnerTargetSetterTranslationCommon)((IOwnerTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = OwnerTarget.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public OwnerTarget DeepCopy(
            IOwnerTargetGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            OwnerTarget ret = (OwnerTarget)((OwnerTargetCommon)((IOwnerTargetGetter)item).CommonInstance()!).GetNew();
            ((OwnerTargetSetterTranslationCommon)((IOwnerTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class OwnerTarget
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => OwnerTarget_Registration.Instance;
        public static OwnerTarget_Registration Registration => OwnerTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => OwnerTargetCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterInstance()
        {
            return OwnerTargetSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => OwnerTargetSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IOwnerTargetGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IOwnerTargetGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IOwnerTargetGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class OwnerTargetBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static OwnerTargetBinaryWriteTranslation Instance = new OwnerTargetBinaryWriteTranslation();

        public virtual void Write(
            MutagenWriter writer,
            IOwnerTargetGetter item,
            TypedWriteParams? translationParams = null)
        {
        }

        public virtual void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IOwnerTargetGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    public partial class OwnerTargetBinaryCreateTranslation
    {
        public readonly static OwnerTargetBinaryCreateTranslation Instance = new OwnerTargetBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class OwnerTargetBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IOwnerTargetGetter item,
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((OwnerTargetBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class OwnerTargetBinaryOverlay :
        PluginBinaryOverlay,
        IOwnerTargetGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => OwnerTarget_Registration.Instance;
        public static OwnerTarget_Registration Registration => OwnerTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => OwnerTargetCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => OwnerTargetSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IOwnerTargetGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IOwnerTargetGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IOwnerTargetGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        public virtual IEnumerable<IFormLinkGetter> ContainedFormLinks => OwnerTargetCommon.Instance.GetContainedFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => OwnerTargetBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((OwnerTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected OwnerTargetBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }


        #region To String

        public virtual void ToString(
            FileGeneration fg,
            string? name = null)
        {
            OwnerTargetMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IOwnerTargetGetter rhs) return false;
            return ((OwnerTargetCommon)((IOwnerTargetGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IOwnerTargetGetter? obj)
        {
            return ((OwnerTargetCommon)((IOwnerTargetGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((OwnerTargetCommon)((IOwnerTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

