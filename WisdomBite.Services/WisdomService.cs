using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisdombite.Data;
using Wisdombite.Models;
using WisdomBite.Data;

namespace ElevenNote.Services
{
    public class WisdomService
    {
        private readonly Guid _userId;

        public WisdomService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateNote(WisdomBasicItem wisdomToCreate)
        {
            var entity =
                new Wisdom()
                {
                    Content = wisdomToCreate.Content,
                    WisdomGenre = wisdomToCreate.WisdomGenre
                };
            using (var ctx = new ApplicationDbContext())
            {
                entity.Author = ctx.AuthorTable.Find(wisdomToCreate.AuthorId);
                entity.CreatedAt = DateTime.Now;
                ctx.WisdomTable.Add(entity);
            }
        }
        public IEnumerable<WisdomListItem> GetNotes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .WisdomTable
                        .Select(
                            e =>
                                new WisdomListItem
                                {
                                    Content = e.Content,
                                    AuthorName = e.Author.FullName,
                                    WisdomGenre = e.WisdomGenre,

                                });

                return query.ToArray();
            }
        }
    }
}
