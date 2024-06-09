using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories
{
    public class DeleteCategoryRequest : Request
    {
        public int Id { get; set; }
    }
}