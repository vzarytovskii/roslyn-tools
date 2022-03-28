// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
// See the License.txt file in the project root for more information.

using System.CommandLine;

namespace Microsoft.Roslyn.Tool.Commands;

internal static class RootRoslynCommand
{
    public static RootCommand GetRootCommand()
    {
        var command = new RootCommand()
        {
            PRFinderCommand.GetCommand(),
            NuGetPrepareCommand.GetCommand(),
            NuGetPublishCommand.GetCommand(),
            CreateReleaseTagsCommand.GetCommand(),
            VSBranchInfoCommand.GetCommand(),
        };
        command.Name = "roslyn";
        command.Description = "The command line tool for performing Roslyn infrastructure tasks.";
        return command;
    }
}
