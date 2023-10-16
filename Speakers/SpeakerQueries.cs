using ConferencePlanner.GraphQL.Data;
using ConferencePlanner.GraphQL.DataLoader;
namespace ConferencePlanner.GraphQL.Speakers
{
    [ExtendObjectType("Query")]
    [Obsolete]
    public class SpeakerQueries
    {
        [UseApplicationDbContext]
        [UsePaging]
        public IQueryable<Speaker> GetSpeakers(
            [ScopedService] ApplicationDbContext context) =>
            context.Speakers.OrderBy(t => t.Name);
        // [UseApplicationDbContext]
        // public Task<List<Speaker>> GetSpeakersAsync(
        //     [ScopedService] ApplicationDbContext context) =>
        //     context.Speakers.ToListAsync();

        public Task<Speaker> GetSpeakerByIdAsync(
            [ID(nameof(Speaker))] int id,
            SpeakerByIdDataLoader dataLoader,
            CancellationToken cancellationToken) =>
            dataLoader.LoadAsync(id, cancellationToken);

        public async Task<IEnumerable<Speaker>> GetSpeakersByIdAsync(
            [ID(nameof(Speaker))] int[] ids,
            SpeakerByIdDataLoader dataLoader,
            CancellationToken cancellationToken) =>
            await dataLoader.LoadAsync(ids, cancellationToken);
    }
}