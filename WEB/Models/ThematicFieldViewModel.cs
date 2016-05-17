using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BL.DTOs;

namespace WEB.Models {
    public class ThematicFieldViewModel {

        public List<ThematicFieldDTO> ThematicFields{ get; set; }

        public ThematicFieldViewModel() {
            ThematicFields = new List<ThematicFieldDTO>();
        }
    }
}