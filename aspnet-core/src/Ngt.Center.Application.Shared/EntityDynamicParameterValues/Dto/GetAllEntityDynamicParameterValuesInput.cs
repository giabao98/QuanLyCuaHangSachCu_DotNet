using System.ComponentModel.DataAnnotations;

namespace Ngt.Center.EntityDynamicParameterValues.Dto
{
    public class GetAllEntityDynamicParameterValuesInput
    {
        [Required]
        public string EntityFullName { get; set; }

        [Required]
        public string EntityId { get; set; }
    }
}
