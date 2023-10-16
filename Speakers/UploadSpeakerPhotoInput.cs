using ConferencePlanner.GraphQL.Data;

namespace ConferencePlanner.GraphQL.Speakers
{
    public record UploadSpeakerPhotoInput([ID(nameof(Speaker))]int Id, IFile Photo);
}