using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MusicTracks2.Models
{
    public class MusicTracks2Context : DbContext
    {
        public MusicTracks2Context (DbContextOptions<MusicTracks2Context> options)
            : base(options)
        {
        }

        public DbSet<MusicTracks2.Models.MusicTrack> MusicTrack { get; set; }
    }
}
