using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Hizmet İcon Linki Giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet İcon Başlığı Giriniz")]
        [StringLength(100,ErrorMessage ="Hizmet başlığı en fazla 100 karakter olabilir")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
