using Kiwimob.Framework.Repository.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kiwimob.Framework.Repository.EntityFramework
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}