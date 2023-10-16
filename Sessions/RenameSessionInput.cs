using ConferencePlanner.GraphQL.Data;

namespace ConferencePlanner.GraphQL.Sessions
{
    public record RenameSessionInput(
        [property: ID(nameof(Session))] string SessionId,
        string Title);
}