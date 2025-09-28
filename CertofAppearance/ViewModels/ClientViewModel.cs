using Microsoft.AspNetCore.Mvc.Rendering;

namespace CertofAppearance.ViewModels;

public class ClientViewModel
{
    public List<SelectListItem> Signatories { get; set; }
}