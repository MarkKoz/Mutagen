﻿using System.Text;

namespace Mutagen.Bethesda.Plugins.Exceptions;

public class UnmappableFormIDException : Exception
{
    public FormKey UnmappableFormKey { get; }
    public IReadOnlyList<ModKey> ListedMasters { get; }

    public UnmappableFormIDException(FormKey unmappableFormKey, IReadOnlyList<ModKey> listedMasters)
        : base("Could not map FormKey to a master index")
    {
        UnmappableFormKey = unmappableFormKey;
        ListedMasters = listedMasters;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append(UnmappableFormKey);
        sb.AppendLine(" could not be located within:");
        int i = 0;
        foreach (var modKey in ListedMasters)
        {
            sb.Append("  [");
            sb.Append(i++);
            sb.Append("] ");
            sb.Append(modKey);
            sb.AppendLine();
        }

        return sb.ToString();
    }
}