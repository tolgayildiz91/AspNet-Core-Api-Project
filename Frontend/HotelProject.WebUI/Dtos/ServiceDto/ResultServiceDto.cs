using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class ResultServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet İcon Linki Giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı Giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması Giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet açıklaması en fazla 500 karakter olabilir")]
        public string Description { get; set; }
    }
}
