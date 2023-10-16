using ConferencePlanner.GraphQL.Data;

namespace ConferencePlanner.GraphQL.Speakers
{
    public record ModifySpeakerInput(
        [property: ID(nameof(Speaker))] 
        int Id,
        Optional<string?> Name,
        Optional<string?> Bio,
        Optional<string?> WebSite);
}