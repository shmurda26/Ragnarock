using Ragnarock.Models;
using Ragnarock.Interfaces;

namespace Ragnarock.Services
{
    public class ArtifactCatalog:IArtifactsRepository
    {
        private Dictionary<int, Artifacts> Artifacts { get; }

        public ArtifactCatalog()
        {
            Artifacts = new Dictionary<int, Artifacts>();
            Artifacts.Add(1, new Artifacts() { Id = 1, Name = "Artifact 1", Description = "something", Year = 2020, ImageName = "pladespiller.jpg" });
            Artifacts.Add(2, new Artifacts() { Id = 2, Name = "Artifact 2", Description = "something", Year = 2020, ImageName = "pladespiller.jpg" });
            Artifacts.Add(3, new Artifacts() { Id = 3, Name = "Artifact 3", Description = "something", Year = 2020, ImageName = "pladespiller.jpg" });
        }
        public Dictionary<int, Artifacts> AllArtifacts()
        {
            return Artifacts;
        }
        public void AddArtifacts(Artifacts artifacts)
        {
            if (!Artifacts.Keys.Contains(artifacts.Id))
                Artifacts.Add(artifacts.Id, artifacts);
        }
        public Dictionary<int, Artifacts> FilterArtifacts(string criteria)
        {
            Dictionary<int, Artifacts> myArtifacts = new Dictionary<int, Artifacts>();
            if (criteria != null)
            {
                foreach (var a in Artifacts.Values)
                {
                    if (a.Name.ToLower().StartsWith(criteria.ToLower()))
                    {
                        myArtifacts.Add(a.Id, a);
                    }
                }
            }
            return myArtifacts;
        }
        public Artifacts GetArtifacts(int Id)
        {
            return Artifacts[Id];
        }

        public void UpdateArtifacts(Artifacts artifact)
        {
            if (artifact != null)
            {
                Artifacts[artifact.Id] = artifact;
            }
        }
        public void DeleteArtifacts(Artifacts artifact)
        {
            if (artifact != null)
            {
                Artifacts.Remove(artifact.Id);
            }
        }

    }
}

