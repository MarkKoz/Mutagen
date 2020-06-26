﻿using Loqui;
using Loqui.Generation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda.Generation
{
    public class WarmupModule : GenerationModule
    {
        public override async Task FinalizeGeneration(ProtocolGeneration proto)
        {
            await base.FinalizeGeneration(proto);
            if (proto.Protocol.Namespace == "Bethesda") return;

            bool all = proto.Protocol.Namespace == "All";

            FileGeneration fg = new FileGeneration();
            fg.AppendLine("using Loqui;");
            fg.AppendLine();

            using (new NamespaceWrapper(fg, proto.DefaultNamespace))
            {
                using (var comment = new CommentWrapper(fg))
                {
                    comment.Summary.AppendLine("A static class to house initialization warmup logic");
                }
                using (var c = new ClassWrapper(fg, $"Warmup{proto.Protocol.Namespace}"))
                {
                    c.Static = true;
                }
                using (new BraceWrapper(fg))
                {
                    using (var comment = new CommentWrapper(fg))
                    {
                        comment.Summary.AppendLine("Will initialize internals in a more efficient way that avoids reflection.");
                        comment.Summary.AppendLine("Not required to call, but can be used to warm up ahead of time.");
                        if (!all)
                        {
                            comment.Summary.AppendLine("<br/><br/>NOTE: Calling this warmup which is for a single game, will require you warm up");
                            comment.Summary.AppendLine("other games in the same fashion.  Use WarmupAll if you want all games to be warmed.");
                        }
                    }
                    using (var args = new FunctionWrapper(fg,
                        "public static void Init"))
                    {
                    }
                    using (new BraceWrapper(fg))
                    {
                        if (all)
                        {
                            using (var args = new ArgsWrapper(fg,
                                $"Loqui.Initialization.SpinUp"))
                            {
                                args.Add($"new ProtocolDefinition_Bethesda()");
                            }
                            foreach (var otherProto in proto.Gen.Protocols.Values
                                .Where(p => p.DefaultNamespace.Contains("Mutagen.Bethesda"))
                                .Where(p => p.DefaultNamespace.Length > "Mutagen.Bethesda".Length)
                                .Where(p => !object.ReferenceEquals(p, proto)))
                            {
                                fg.AppendLine($"{otherProto.DefaultNamespace}.Warmup{otherProto.Protocol.Namespace}.Init();");
                            }
                        }
                        else
                        {
                            using (var args = new ArgsWrapper(fg,
                                $"Loqui.Initialization.SpinUp"))
                            {
                                args.Add($"new ProtocolDefinition_Bethesda()");
                                args.Add($"new ProtocolDefinition_{proto.Protocol.Namespace}()");
                            }
                        }
                    }
                }
            }
            var path = Path.Combine(proto.DefFileLocation.FullName, $"../Warmup{proto.Protocol.Namespace}.cs");
            fg.Generate(path);
            proto.GeneratedFiles.Add(path, ProjItemType.Compile);
        }
    }
}
