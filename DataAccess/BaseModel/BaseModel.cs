using System.ComponentModel.DataAnnotations;

namespace DataAccess.BaseModel
{
    public abstract class BaseModel<TKey> where TKey : struct
    {
        [Key]
        public TKey? Id { get; set; }
    }
}
