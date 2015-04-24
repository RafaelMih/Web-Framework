using System.ComponentModel.DataAnnotations.Schema;

namespace Kiwimob.Framework.Repository.Infrastructure
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}