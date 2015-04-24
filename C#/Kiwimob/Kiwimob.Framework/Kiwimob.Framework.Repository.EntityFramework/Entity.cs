using System.ComponentModel.DataAnnotations.Schema;
using Kiwimob.Framework.Repository.Infrastructure;

namespace Kiwimob.Framework.Repository.EntityFramework
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}