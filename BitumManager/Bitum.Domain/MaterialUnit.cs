using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitum.Domain
{
    public class MaterialUnit
    {
        public required Guid Id { get; init; }//указать дальше, что обязателен при создании

        public required double Weight { get; set; }

        public required DateTime ManufactureDate { get; set; }

        public Material Мaterial { get; set; }

        public string Note { get; set; }

        public string Recept {  get; set; }
    }
}
