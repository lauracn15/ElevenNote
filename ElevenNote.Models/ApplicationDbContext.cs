using System;

namespace ElevenNote.Models
{
    internal class ApplicationDbContext : IDisposable
    {
        public object Notes { get; internal set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}