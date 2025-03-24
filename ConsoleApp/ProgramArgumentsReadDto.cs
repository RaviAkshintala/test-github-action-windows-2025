using CommandLine;

namespace ConsoleApp;

public record ProgramArgumentsReadDto
{
    [Option("flavor", Required = true, HelpText = "Which flavor of the artifact should be created by the setup")]
    public required string Flavor { get; init; }
    
    [Option("environment", Required = true, HelpText = "Whether the final installed artifact should point to staging or production apis, and whether the final artifact should be uploaded to staging or production backoffice")]
    public required string Environment { get; init; }
    
    [Option("version", Required = true, HelpText = "The sem-ver of the artifact. Will also be appended to the setup filename")]
    public required string Version { get; init; }
}
