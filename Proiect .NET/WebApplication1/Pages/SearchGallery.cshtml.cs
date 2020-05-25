using ServiceReference1;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace WebApplication1.Pages
{
    public class SearchGalleryModel : PageModel
    {
        
        Interface1Client interfaceclient = new Interface1Client();

        [BindProperty(SupportsGet = true)]

        public List<WebGalleryDTO> element { get; set; }

        public string DbSearch { get; set; }
        
        ///public object Info { get; private set; }
        public SearchGalleryModel()
        {
            element = new List<WebGalleryDTO>();
        }
        public async Task OnGetAsync()
        {
            int contor = 1;

            var val = await interfaceclient.InfoAsync();
            
            WebGalleryDTO el = new WebGalleryDTO();

            foreach (var item in val)
            {
                //Console.WriteLine(item);
                if (contor == 1)
                {
                    el.Id = Int32.Parse(item);
                }
                else if (contor == 2)
                {
                    el.Name = item;
                }   
                else if (contor == 3)
                {
                    el.Date = item;
                    element.Add(el);
                    contor = 0;
                    el = new WebGalleryDTO();
                }
                contor = contor + 1;
            }
        }
    }
}