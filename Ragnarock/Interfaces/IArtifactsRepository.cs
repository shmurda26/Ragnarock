using Ragnarock.Models;

namespace Ragnarock.Interfaces
{
    public interface IArtifactsRepository
    {
        Dictionary<int, Artifacts> AllArtifacts();
        Dictionary<int, Artifacts> FilterArtifacts(string crtiteria);
        void DeleteArtifacts(Artifacts artifact);
        void AddArtifacts(Artifacts artifact);
        void UpdateArtifacts(Artifacts artifact);
        Artifacts GetArtifacts(int id);
    }
}
